using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Exceptions;
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
    public partial class AccidentsMonitoringMenu : Form
    {
        private ExcelWorksheet _sheet;
        private SearchService _search;
        private Func<SearchModel> GetSearchDetails;
        private IEnumerable<string> _years;
        private bool isLoaded;

        public AccidentsMonitoringMenu()
        {
            InitializeComponent();
        }

        private void AccidentsMonitoringMenu_Load(object sender, EventArgs e)
        {
            radioPeriod.Checked = true;
            using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\ACOMPANHAMENTO DE ACIDENTES 2020_PAINEL_PROJETO_rev4.xlsx")))
            {
                _sheet = project.Workbook.Worksheets[0];
                _search = new SearchService(_sheet);
                GetSheetYears(_search.GetYearsColumn().GroupBy(c => c).Select(g => g.Key));
                comboInitialYear.Items.AddRange(_years.Prepend("").ToArray());
                comboInitialYear.SelectedIndex = 1;
                comboFinalYear.Items.AddRange(_years.Prepend("").ToArray());
                comboFinalYear.SelectedIndex = comboFinalYear.Items.Count - 1;
                
                comboYear.Items.AddRange(_years.ToArray());
                comboYear.SelectedIndex = 0;

                txtInitialYearAll.Text = _years.First();
                txtFinalYearAll.Text = _years.Last();
                isLoaded = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region initial testings TO DELETE
            //int value_1 = int.Parse(txtValue_1.Text);
            //int value_2 = int.Parse(txtValue_2.Text);

            //ChartScreen chartScreen = new ChartScreen();
            //chartScreen.Values = new List<int>();
            //chartScreen.Values.AddRange(new int[] { value_1, value_2 });
            //chartScreen.TotalValue = int.Parse(txtTotalValue.Text);
            //chartScreen.Show();
            #endregion
            using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\ACOMPANHAMENTO DE ACIDENTES 2020_PAINEL_PROJETO_rev4.xlsx")))
            {
                _sheet = project.Workbook.Worksheets[0];
                _search = new SearchService(_sheet);
                SearchModel _searchDetails = GetSearchDetails();

                try
                {
                    IEnumerable<Accident> result = _search.AdvSearch(_searchDetails);

                    

                    RatioChartScreen ratioChartScreen = new RatioChartScreen()
                    {
                        //Stats = new List<Stats>() { new Stats("TOR", torList), new Stats("TAR", tarList) },
                        ResultGroup = StatsCalculator.GetByAccidentType(result),
                        TotalValue = result.Count()
                    };

                    ratioChartScreen.Show();
                    WindowState = FormWindowState.Minimized;

                }
                catch (ResultNotFoundException)
                {
                    lblNoResults.Visible = true;
                }
            }
        }

        private void GetSheetYears(IEnumerable<string> years)
        {
            List<string> aux = new List<string>();
            foreach (string item in years)
            {
                aux.Add(item);
            }
            _years = aux;
        }

        private void comboInitialYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                string currentItem = comboFinalYear.SelectedItem.ToString();
                if (comboInitialYear.SelectedIndex > 1)
                {
                    if (comboFinalYear.SelectedItem.ToString() != "" && int.Parse(comboFinalYear.SelectedItem.ToString()) < int.Parse(comboInitialYear.SelectedItem.ToString()))
                    {
                        comboFinalYear.SelectedIndex = 0;
                    }
                    comboFinalYear.Items.Clear();
                    comboFinalYear.Items.AddRange(_years.Where(y => int.Parse(y) >= int.Parse(comboInitialYear.SelectedItem.ToString())).Prepend("").ToArray());
                    comboFinalYear.SelectedItem = comboFinalYear.Items.Contains(currentItem) ? currentItem : "";
                }
                else if (comboFinalYear.Items.Count > 0)
                {
                    comboFinalYear.Items.Clear();
                    comboFinalYear.Items.AddRange(_years.Prepend("").ToArray());
                    comboFinalYear.SelectedItem = comboFinalYear.Items.Contains(currentItem) ? currentItem : "";
                }
            }
        }

        private void comboFinalYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioPeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPeriod.Checked)
            {
                panDataMenuPeriod.Visible = true;
                lblTitle.Text = "Escolha o Período";
                GetSearchDetails = () => new SearchModel()
                {
                    InitialDate = comboInitialYear.SelectedIndex > 1 ? DateTime.Parse(comboInitialYear.SelectedItem.ToString() + "/01/01") : DateTime.Parse(_years.ElementAt(0) + "/01/01"),
                    FinalDate = comboFinalYear.SelectedItem.ToString() != "" ? DateTime.Parse(comboFinalYear.SelectedItem.ToString() + "/12/31") : DateTime.Parse(_years.Last() + "/12/31")
                };
            }
            else
            {
                panDataMenuPeriod.Visible = false;
            }
        }

        private void radioYear_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYear.Checked)
            {
                panDataMenuYear.Visible = true;
                lblTitle.Text = "Escolha o Ano";
                GetSearchDetails = () => new SearchModel()
                {
                    Year = int.Parse(comboYear.SelectedItem.ToString())
                };
            }
            else
            {
                panDataMenuYear.Visible = false;
            }
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAll.Checked)
            {
                panDataMenuAll.Visible = true;
                lblTitle.Text = "Todo o Período";
                GetSearchDetails = () => new SearchModel();
            }
            else
            {
                panDataMenuYear.Visible = false;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
