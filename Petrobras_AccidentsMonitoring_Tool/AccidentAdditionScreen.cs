using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class AccidentAdditionScreen : Form
    {
        public AccidentAdditionScreen()
        {
            InitializeComponent();
        }

        private void AccidentAdditionScreen_Load(object sender, EventArgs e)
        {
            using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\sheetbak.xlsx")))
            {
                ExcelWorksheet sheet = project.Workbook.Worksheets[0];
                ManagementService managementService = new ManagementService(sheet);
                
            }
        }
    }
}
