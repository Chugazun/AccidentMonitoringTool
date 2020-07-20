using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Enums;
using Petrobras_AccidentsMonitoring_Tool.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrobras_AccidentsMonitoring_Tool.Services
{
    class ManagementService : SheetService
    {
        public ManagementService(ExcelWorksheet sheet) : base(sheet)
        {

        }

        public void AddAccident(Accident accident)
        {
            CreateRow();
            RowSerialize(LastRow, accident);
        }

        public void EditAccident(Accident accident)
        {
            int row = accident.ID;
            ClearClassForEdit(row);
            RowSerialize(row, accident);
        }

        private void RowSerialize(int row, Accident accident)
        {
            _sheet.Cells[row, 1].Value = accident.Company;
            _sheet.Cells[row, 3].Value = accident.Sector.ToUpper();
            _sheet.Cells[row, 5].Value = accident.EmployeeName;
            _sheet.Cells[row, 7].Value = accident.JobRole;

            if (accident.Class.HasValue) _sheet.Cells[row, GetClassPos(accident.Class.Value)].Value = "X";
            else _sheet.Cells[row, GetTypeGradePos(accident.AccidentType.Value, accident.Grade)].Value = "X";

            _sheet.Cells[row, 19].Value = accident.Date.Value.Day;
            _sheet.Cells[row, 20].Value = Utilities.ConvertMonth(accident.Date.Value.Month);
            _sheet.Cells[row, 21].Value = accident.Date.Value.Year;
            _sheet.Cells[row, 22].Value = accident.WeekDay;
            _sheet.Cells[row, 23].Value = accident.Time.Value;
            _sheet.Cells[row, 24].Value = accident.Place;
            _sheet.Cells[row, 25].Value = accident.InjuryType;
            _sheet.Cells[row, 26].Value = accident.BodyPart;
            _sheet.Cells[row, 27].Value = accident.Description;
            _sheet.Cells[row, 28].Value = accident.RTA.ToUpper();
            _sheet.Cells[row, 30].Value = accident.CAT;
            _sheet.Row(row).CustomHeight = false;
        }

        private void CreateRow()
        {
            var lastRow = _sheet.Cells[LastRow, 1, LastRow, 31];
            var newRow = _sheet.Cells[LastRow + 1, 1, LastRow + 1, 31];
            lastRow.Copy(newRow);
            newRow.Value = "";
            TotalEntries++;
            LastRow++;
        }

        private int GetClassPos(int accidentClass)
        {
            return 9 + accidentClass;
        }

        private int GetTypeGradePos(AccidentType accidentType, string accidentGrade)
        {
            int[] typePos = _accidentTypePos[accidentType];
            return accidentGrade == "Sem Afastamento" ? typePos[0] : typePos[1];
        }

        private void ClearClassForEdit(int row)
        {
            var classPos = _sheet.Cells[row, 9, row, 18].FirstOrDefault(c => c.Text.Trim().ToLower() == "x");
            if (classPos != null) classPos.Value = "";
        }
    }
}
