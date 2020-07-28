using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Services;
using Petrobras_AccidentsMonitoring_Tool.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class DaysMonitoringScreen : Form
    {
        private string[] _sectors;
        private string _accidentType;
        private List<Accident> _accidents;

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
            _accidents = new List<Accident>();
            using (var project = new ExcelPackage(new FileInfo($@"{Properties.Resources.MainSheet}")))
            {
                var _sheet = project.Workbook.Worksheets[0];
                SearchService searchService = new SearchService(_sheet);

                foreach (string sector in _sectors)
                {                    
                    Accident aux = searchService.GetLastAccident(sector, 3, ConvertAccidentType(_accidentType));
                    _accidents.Add(aux);
                    if(aux != null)
                    {
                        int result = Utilities.GetDaysInterval(aux.Date.Value);
                        listAccidents.Items.Add($"- {sector}: {result} dias. ({Utilities.ConvertToDate(result).ToString("dd/MM/yyyy")})");
                    } else
                    {
                        listAccidents.Items.Add($"- {sector}: Nenhum acidente encontrado.");
                    }
                }
            }
        }

        private int ConvertAccidentType(string typeAsString)
        {
            return typeAsString == "TAR" ? 2 : 0;
        }

        private void listAccidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listAccidents.SelectedIndex;
            if(_accidents[index] != null)
            {
                AccidentDetailsScreen accidentDetailsScreen = new AccidentDetailsScreen(_accidents[index]);
                accidentDetailsScreen.Show();
            }
        }
    }
}
