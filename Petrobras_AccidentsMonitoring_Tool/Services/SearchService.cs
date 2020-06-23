using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Exceptions;
using Petrobras_AccidentsMonitoring_Tool.Utils;
using Petrobras_AccidentsMonitoring_Tool.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Petrobras_AccidentsMonitoring_Tool.Services
{
    class SearchService : SheetService
    {
        public SearchService(ExcelWorksheet sheet) : base(sheet)
        {

        }

        public IEnumerable<Accident> AdvSearch(SearchModel searchParameters)
        {
            Dictionary<int, string> filters = new Dictionary<int, string>();

            if (searchParameters.Company != null) filters.Add(1, searchParameters.Company);
            if (searchParameters.Sector != null) filters.Add(3, searchParameters.Sector);
            if (searchParameters.EmployeeName != null) filters.Add(5, searchParameters.EmployeeName);
            if (searchParameters.InjuryType != null) filters.Add(25, searchParameters.InjuryType);
            if (searchParameters.Class.HasValue) filters.Add(9 + searchParameters.Class.Value, "x");
            if (searchParameters.Year.HasValue) { filters.Add(20, searchParameters.Year.Value.ToString()); }
            else if (searchParameters.InitialDate.HasValue || searchParameters.FinalDate.HasValue)
            {
                string initialDate = searchParameters.InitialDate.HasValue ? searchParameters.InitialDate.Value.ToString(@"dd/MM/yyyy") : new DateTime(GetDate(5).Year, 01, 01).ToString(@"dd/MM/yyyy");
                string finalDate = searchParameters.FinalDate.HasValue ? searchParameters.FinalDate.Value.ToString(@"dd/MM/yyyy") : new DateTime(GetDate(LastRow).Year, 12, 31).ToString(@"dd/MM/yyyy");

                filters.Add(19, initialDate + " " + finalDate);
            }

            int[] validRows = GetRows(filters).ToArray();

            if (validRows.Length <= 0)
            {
                throw new ResultNotFoundException("Nenhum resultado encontrado.");
            }
            else
            {
                List<Accident> result = new List<Accident>();
                foreach (int row in validRows)
                {
                    result.Add(RowDeserialize(row));
                }
                return result;
            }
        }

        private IEnumerable<int> GetRows(Dictionary<int, string> rowFilters)
        {
            int searchCount = LastRow;
            int startingRow = 5;

            if (rowFilters.ContainsKey(20))
            {
                int[] yearIndexes = GetYearInterval(rowFilters[20]).ToArray();
                startingRow = yearIndexes[0];
                searchCount = yearIndexes[1];
            }
            else if (rowFilters.ContainsKey(19))
            {
                string[] dates = rowFilters[19].Split(' ');
                int[] yearIndexes = GetYearInterval(dates[0], dates[1]).ToArray();

                startingRow = yearIndexes[0];
                searchCount = yearIndexes[1];
            }

            for (int i = startingRow; i <= searchCount; i++)
            {
                var row = _sheet.Cells[i, 1, i, 25];
                if (ValidateRow(row, rowFilters)) yield return i;
            }
        }

        private bool ValidateRow(ExcelRange selectedRow, Dictionary<int, string> rowFilters)
        {
            foreach (var filter in rowFilters)
            {
                if (filter.Key == 20) { return true; }
                else if (filter.Key == 19)
                {
                    string[] dates = filter.Value.Split(' ');
                    DateTime initialDate = DateTime.Parse(dates[0]);
                    DateTime finalDate = DateTime.Parse(dates[1]);
                    DateTime selectedDate = GetDate(selectedRow.Start.Row);
                    return selectedDate >= initialDate && selectedDate <= finalDate;
                }
                else if (selectedRow[selectedRow.Start.Row, filter.Key].Text.ToLower().Trim() != filter.Value.ToString().ToLower()) return false;
            }
            return true;
        }

        private Accident RowDeserialize(int row)
        {
            TimeSpan? time = _sheet.Cells[row, 23].Text != "" ? TimeSpan.Parse(_sheet.Cells[row, 23].Text) : (TimeSpan?)null;
            Accident result = new Accident(row)
            {                
                Company = _sheet.Cells[row, 1].Text,
                Sector = _sheet.Cells[row, 3].Text,
                Supervisor = _sheet.Cells[row, 4].Text,
                EmployeeName = _sheet.Cells[row, 5].Text,
                JobRole = _sheet.Cells[row, 7].Text,
                Class = GetAccidentClass(row).HasValue ? GetAccidentClass(row).Value : (int?)null,
                Date = GetDate(row),
                Time = time,
                WeekDay = _sheet.Cells[row, 22].Text,
                Place = _sheet.Cells[row, 24].Text,
                InjuryType = _sheet.Cells[row, 25].Text,
                BodyPart = _sheet.Cells[row, 26].Text,
                RTA = _sheet.Cells[row, 28].Text,
                RPA = _sheet.Cells[row, 29].Text,
                CAT = _sheet.Cells[row, 30].Text
            };
            result.AccidentType = GetAccidentType(row, result.Class);
            return result;
        }       

        private AccidentType GetAccidentType(int row, int? accidentClass)
        {
            if (accidentClass.HasValue)
            {
                return (AccidentType)1;
            }
            else if (_sheet.Cells[row, 15].Text.ToLower() == "x" || _sheet.Cells[row, 16].Text.ToLower() == "x")
            {
                return (AccidentType)2;
            }
            else
            {
                return (AccidentType)3;
            }

        }

        private DateTime GetDate(int selectedRow)
        {
            DateTime aux = new DateTime(
                int.Parse(_sheet.Cells[selectedRow, 21].Text),
                Utilities.ConvertMonth(Utilities.FindMonth(_sheet.Cells[selectedRow, 20].Text)),
                int.Parse(_sheet.Cells[selectedRow, 19].Text)
            );
            return aux;
        }

        private IEnumerable<int> GetYearInterval(string yearAsString)
        {
            List<string> yearColumn = GetYearsColumn().ToList();

            yield return yearColumn.IndexOf(yearAsString) + 5;
            yield return yearColumn.LastIndexOf(yearAsString) + 5;
        }

        private IEnumerable<int> GetYearInterval(string dateString_1, string dateString_2)
        {
            int year_1 = DateTime.Parse(dateString_1).Year;
            int year_2 = DateTime.Parse(dateString_2).Year;

            List<string> yearColumn = GetYearsColumn().ToList();

            yield return yearColumn.IndexOf(year_1.ToString()) + 5;
            yield return yearColumn.LastIndexOf(year_2.ToString()) + 5;
        }

        public int GetDaysIntervalOLD(string target, int searchColumn, int typeAsInt)
        {
            int aux = -1;
            DateTime? date = null;

            var result = _sheet.Cells[5, searchColumn, LastRow, searchColumn].Where(c => c.Text.Contains(target.Trim()) && GetAccidentClass(c.Start.Row).HasValue && GetAccidentClass(c.Start.Row).Value >= typeAsInt)
                                                                                      .LastOrDefault();

            if (result != null) date = GetDate(result.Start.Row);

            //for (int i = LastRow; i > 5; i--)
            //{
            //    if (_sheet.Cells[i, searchColumn].Text == target)
            //    {
            //        int? accidentClass = GetAccidentClass(i);
            //        if (accidentClass.HasValue && accidentClass.Value >= 2)
            //        {
            //            date = GetDate(i);
            //            break;
            //        }
            //    }
            //}
            if (!date.HasValue) return aux;

            DateTime currentDay = DateTime.Now;
            TimeSpan diff = currentDay.Subtract(date.Value);
            aux = diff.Days - 1;
            return aux;
        }

        public Accident GetLastAccident(string target, int searchColumn, int typeAsInt)
        {
            Accident aux = null;
            var result = _sheet.Cells[5, searchColumn, LastRow, searchColumn].Where(c => c.Text.Contains(target.Trim()) && GetAccidentClass(c.Start.Row).HasValue && GetAccidentClass(c.Start.Row).Value >= typeAsInt)
                                                                                      .LastOrDefault();

            if (result != null)
            {
                int selectedRow = result.Start.Row;
                aux = RowDeserialize(selectedRow);
                aux.Description = _sheet.Cells[selectedRow, 27].Text;
            }
            return aux;
        }

        #region Unused ParseDate method
        //private DateTime ParseDate(string dateAsString, int yearNum)
        //{
        //    DateTime aux;
        //    if (DateTime.TryParse(dateAsString, out aux))
        //    {
        //        return aux;
        //    }
        //    else
        //    {
        //        if (yearNum == 1)
        //        {
        //            aux = new DateTime(GetDate(5).Year, 01, 01);
        //        }
        //        else aux = GetDate(LastRow);

        //        return aux;
        //    }
        //}
        #endregion
    }
}
