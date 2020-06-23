using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrobras_AccidentsMonitoring_Tool.Services
{
    abstract class SheetService
    {
        protected ExcelWorksheet _sheet;
        public int TotalEntries { get; protected set; }
        public int LastRow { get; protected set; }

        public SheetService(ExcelWorksheet sheet)
        {
            _sheet = sheet;
            SetTotalEntries();
            LastRow = TotalEntries + 4;
        }

        private void SetTotalEntries()
        {
            int currentRow = 5;
            do
            {
                TotalEntries++;
            } while (_sheet.Cells[++currentRow, 21].Text != "");
        }

        public IEnumerable<string> GetYearsColumn()
        {
            foreach (var cell in _sheet.Cells[5, 21, LastRow, 21])
            {
                yield return cell.Text;
            }
        }

        public IEnumerable<string> GetSectorsColumn()
        {
            foreach (var cell in _sheet.Cells[5, 3, LastRow, 3])
            {
                if (cell.Text.Trim() != "") yield return cell.Text;
            }
        }

        protected int? GetAccidentClass(int row)
        {
            for (int i = 9; i < 15; i++)
            {
                if (_sheet.Cells[row, i].Text.ToLower() == "x") return i - 9;
            }
            return null;
        }
    }
}
