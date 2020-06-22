using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Entities;
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
            _sheet.Cells[LastRow, 1].Value = accident.Company;
            _sheet.Cells[LastRow, 3].Value = accident.Sector.ToUpper();
            _sheet.Cells[LastRow, 5].Value = accident.EmployeeName;
            _sheet.Cells[LastRow, 7].Value = accident.JobRole;
            _sheet.Cells[LastRow, GetClassPos(accident.Class.Value)].Value = "X";
            _sheet.Cells[LastRow, 19].Value = accident.Date.Value.Day;
            _sheet.Cells[LastRow, 20].Value = Utilities.ConvertMonth(accident.Date.Value.Month);
            _sheet.Cells[LastRow, 21].Value = accident.Date.Value.Year;
            _sheet.Cells[LastRow, 22].Value = accident.WeekDay;
            _sheet.Cells[LastRow, 23].Value = accident.Time.Value;
            _sheet.Cells[LastRow, 24].Value = accident.Place;
            _sheet.Cells[LastRow, 25].Value = accident.InjuryType;
            _sheet.Cells[LastRow, 26].Value = accident.BodyPart;
            _sheet.Cells[LastRow, 27].Value = accident.Description;
            _sheet.Row(LastRow).CustomHeight = false;
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
    }
}
