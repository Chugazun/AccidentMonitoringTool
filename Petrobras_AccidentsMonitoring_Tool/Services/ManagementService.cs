using OfficeOpenXml;
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

        public void CreateRow()
        {
            var lastRow = _sheet.Cells[LastRow, 1, LastRow, 31];
            var newRow = _sheet.Cells[LastRow + 1, 1, LastRow + 1, 31];
            lastRow.Copy(newRow);
            newRow.Value = "";
        }
    }
}
