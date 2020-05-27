using OfficeOpenXml;
using Petrobras_AccidentMonitoring_Tool_Console.Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class DaysMonitoringScreen : Form
    {
        private string[] _sectors;
        private string _accidentType;

        public DaysMonitoringScreen()
        {
            InitializeComponent();
        }

        public DaysMonitoringScreen(string[] sectors, string accidentType) : this()
        {
            _sectors = sectors;
            _accidentType = accidentType;
        }

        private void DaysMonitoringScreen_Load(object sender, EventArgs e)
        {
            lblTitle.Text += $" ({_accidentType})";
            using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\ACOMPANHAMENTO DE ACIDENTES 2020_PAINEL_PROJETO_rev6.xlsx")))
            {
                var _sheet = project.Workbook.Worksheets[0];
                SearchService searchService = new SearchService(_sheet);                

                foreach (string sector in _sectors)
                {
                    int result = searchService.GetDaysInterval(sector, 3, ConvertAccidentType(_accidentType));
                    if (result != -1)
                    {
                        listAccidents.Items.Add($"- {sector}: {result} dias. ({ConvertToDate(result).ToString("dd/MM/yyyy")})");
                    }
                    else
                    {
                        listAccidents.Items.Add($"- {sector}: Nenhum acidente encontrado.");
                    }
                }
            }
        }

        private DateTime ConvertToDate(int days)
        {
            TimeSpan t = new TimeSpan(days + 1, 0, 0, 0, 0);
            return DateTime.Now.Subtract(t);            
        }

        private int ConvertAccidentType(string typeAsString)
        {
            return typeAsString == "TAR" ? 2 : 0;
        }
    }
}
