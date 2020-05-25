using OfficeOpenXml;
using Petrobras_AccidentMonitoring_Tool_Console.Entities;
using Petrobras_AccidentMonitoring_Tool_Console.Exceptions;
using Petrobras_AccidentMonitoring_Tool_Console.Utils;
using Petrobras_AccidentsMonitoring_Tool.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petrobras_AccidentMonitoring_Tool_Console.Services
{
    class SearchService
    {
        private readonly ExcelWorksheet _sheet;
        public int TotalEntries { get; private set; }


        public SearchService(ExcelWorksheet sheet)
        {
            _sheet = sheet;
            SetTotalEntries();
        }

        private void SetTotalEntries()
        {
            int currentRow = 5;
            do
            {
                TotalEntries++;
            } while (_sheet.Cells[++currentRow, 21].Text != "");
        }

        public string GetAdress(string name)
        {
            return _sheet.Cells[2, 1, 8, 13].FirstOrDefault(c => c.Text == name).Address;
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
                string finalDate = searchParameters.FinalDate.HasValue ? searchParameters.FinalDate.Value.ToString(@"dd/MM/yyyy") : new DateTime(GetDate(TotalEntries + 4).Year, 12, 31).ToString(@"dd/MM/yyyy");

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
            int searchCount = TotalEntries + 4;
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
            Accident result = new Accident()
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

        private int? GetAccidentClass(int row)
        {
            for (int i = 9; i < 15; i++)
            {
                if (_sheet.Cells[row, i].Text.ToLower() == "x") return i - 9;
            }
            return null;
        }

        private AccidentType GetAccidentType(int row, int? accidentClass)
        {
            if (accidentClass.HasValue)
            {
                return AccidentType.Típico;
            }
            else if (_sheet.Cells[row, 15].Text.ToLower() == "x" || _sheet.Cells[row, 16].Text.ToLower() == "x")
            {
                return AccidentType.Trajeto;
            }
            else
            {
                return AccidentType.Equiparado;
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

        public IEnumerable<string> GetYearsColumn()
        {
            foreach (var cell in _sheet.Cells[5, 21, TotalEntries + 4, 21])
            {
                yield return cell.Text;
            }
        }

        public IEnumerable<string> GetSectorsColumn()
        {
            foreach (var cell in _sheet.Cells[5, 3, TotalEntries + 4, 3])
            {
                if (cell.Text.Trim() != "") yield return cell.Text;
            }
        }

        public int GetDaysInterval(string target, int searchColumn)
        {
            int aux = -1;
            DateTime? date = null;

            var result = _sheet.Cells[5, searchColumn, TotalEntries + 4, searchColumn].Where(c => c.Text.Contains(target) && GetAccidentClass(c.Start.Row).HasValue && GetAccidentClass(c.Start.Row).Value >= 0)
                                                                                      .LastOrDefault();

            if (result != null) date = GetDate(result.Start.Row);

            //for (int i = TotalEntries + 4; i > 5; i--)
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
        //        else aux = GetDate(TotalEntries + 4);

        //        return aux;
        //    }
        //}
        #endregion
    }
}
