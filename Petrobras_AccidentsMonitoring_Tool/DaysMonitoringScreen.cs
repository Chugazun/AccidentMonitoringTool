using OfficeOpenXml;
using Petrobras_AccidentMonitoring_Tool_Console.Services;
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
    public partial class DaysMonitoringScreen : Form
    {
        public DaysMonitoringScreen()
        {
            InitializeComponent();
        }

        private void DaysMonitoringScreen_Load(object sender, EventArgs e)
        {
            using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\ACOMPANHAMENTO DE ACIDENTES 2020_PAINEL_PROJETO_rev4.xlsx")))
            {
                var _sheet = project.Workbook.Worksheets[0];
                SearchService searchService = new SearchService(_sheet);

                string[] sectors = new string[] { "RNEST/OP/DC", "RNEST/OP/HDT", "RNEST/OP/TE", "RNEST/OP/UT" };

                foreach (string sector in sectors)
                {
                    int result = searchService.GetDaysInterval(sector, 3);
                    if (result != -1)
                    {
                        listAccidents.Items.Add($"- {sector}: {result} dias.");
                    } else
                    {
                        listAccidents.Items.Add($"- {sector}: Nenhum acidente encontrado.");
                    }
                }
            }
        }
    }
}
