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
    public partial class MainMenu : Form
    {
        private ExcelWorksheet _sheet;
        private SearchService _search;
        private Func<SearchModel> GetSearchDetails;
        private IEnumerable<string> _years, _sectors;
        private Button _currentButton;
        private Panel _currentPanel;
        private bool isLoaded;
        private int currentTag = 2;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            AdjustScreen();
            radioPeriod.Checked = true;
            using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\ACOMPANHAMENTO DE ACIDENTES 2020_PAINEL_PROJETO_rev8.xlsx")))
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

                GetSheetSectors(_search.GetSectorsColumn().GroupBy(c => c).Select(g => g.Key).OrderBy(s => s));
                comboSector_1.Items.AddRange(_sectors.Prepend("RNEST").ToArray());
                comboSector_1.SelectedIndex = 0;
            }

            using (var projectTest = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\sheetbak.xlsx")))
            {
                var sheetBak = projectTest.Workbook.Worksheets[0];
                //sheetBak.Cells["AA78"].Value = sheetBak.Cells["AA76"].Value;
                //sheetBak.Cells[76, 1, 76, 31].Copy(sheetBak.Cells[77, 1, 77, 31]);
                //sheetBak.Row(77).CustomHeight = false;
                ManagementService managementService = new ManagementService(sheetBak);
                projectTest.Save();
            }

            comboType.Items.AddRange(new string[] { "TAR", "TOR" });
            comboType.SelectedIndex = 0;
        }

        private void AdjustScreen()
        {
            lblCurrentTag.Text += currentTag;
            panAccidents.Location = new Point(229, 63);
            panAccidents.Size = new Size(278, 270);
            panDaysTotal.Location = new Point(214, 55);
            panDaysTotal.Size = new Size(315, 334);
            _currentButton = btnAddition;
            _currentPanel = panAddition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\ACOMPANHAMENTO DE ACIDENTES 2020_PAINEL_PROJETO_rev8.xlsx")))
            {
                _sheet = project.Workbook.Worksheets[0];
                _search = new SearchService(_sheet);
                SearchModel _searchDetails = GetSearchDetails();

                try
                {
                    IEnumerable<Accident> result = _search.AdvSearch(_searchDetails);
                    RatioChartScreen ratioChartScreen = new RatioChartScreen(this)
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

        private void GetSheetYears(IEnumerable<string> years)
        {
            List<string> aux = new List<string>();
            foreach (string item in years)
            {
                aux.Add(item);
            }
            _years = aux;
        }

        private void GetSheetSectors(IEnumerable<string> sectors)
        {
            List<string> aux = new List<string>();
            foreach (string item in sectors)
            {
                aux.Add(item);
            }
            _sectors = aux;
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
                panDataMenuAll.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Point previousLocation = Controls.Find("lblSector_" + (currentTag - 1), true)[0].Location;
            Label lblSector = new Label()
            {
                Name = "lblSector_" + currentTag,
                Text = "Setor " + currentTag + ": ",
                Font = lblSector_1.Font,
                Location = new Point(previousLocation.X, previousLocation.Y + 30),
                AutoSize = true,
                Visible = true
            };
            panDaysMain.Controls.Add(lblSector);

            ComboBox comboSector = new ComboBox()
            {
                Name = "comboSector_" + currentTag,
                Tag = "sector",
                AutoCompleteMode = AutoCompleteMode.SuggestAppend,
                AutoCompleteSource = AutoCompleteSource.ListItems,
                Location = new Point(lblSector.Location.X + 60, lblSector.Location.Y - 2),
                Size = new Size(121, 21),
                Visible = true
            };
            comboSector.Items.AddRange(_sectors.Prepend("RNEST").ToArray());
            panDaysMain.Controls.Add(comboSector);
            comboSector.BringToFront();

            btnAdd.Location = new Point(210, btnAdd.Location.Y + 30);
            if (currentTag - 1 != 1)
            {
                btnRemove.Location = new Point(245, btnAdd.Location.Y);
            }
            else
            {
                btnRemove.Visible = true;
            }
            currentTag++;
            lblCurrentTag.Text = "Current Tag (DEBUG): " + currentTag;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Control lastComboBox = Controls.Find("comboSector_" + (currentTag - 1), true)[0];
            Control lastLabel = Controls.Find("lblSector_" + (currentTag - 1), true)[0];
            panDaysMain.Controls.Remove(lastComboBox);
            panDaysMain.Controls.Remove(lastLabel);

            btnAdd.Location = new Point(210, btnAdd.Location.Y - 30);
            if (currentTag - 1 != 2)
            {
                btnRemove.Location = new Point(245, btnAdd.Location.Y);
            }
            else
            {
                btnRemove.Visible = false;
            }
            currentTag--;
            lblCurrentTag.Text = "Current Tag (DEBUG): " + currentTag;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] searchItems = panDaysMain.Controls.OfType<ComboBox>().Where(c => c.Tag.ToString() == "sector")
                                                                      .Select(cb => cb.SelectedItem.ToString())
                                                                      .Reverse()
                                                                      .ToArray();

            DaysMonitoringScreen daysMonitoringScreen = new DaysMonitoringScreen(searchItems, comboType.SelectedItem.ToString());
            daysMonitoringScreen.Show();
        }

        private void TogglePreviousTool(Button newToolButton, Panel newToolPanel)
        {
            _currentButton.BackColor = SystemColors.ControlLight;
            _currentPanel.Visible = false;
            _currentButton = newToolButton;
            _currentPanel = newToolPanel;
        }

        private void btnDays_Click(object sender, EventArgs e)
        {
            TogglePreviousTool(btnDays, panDaysTotal);
            panDaysTotal.Visible = true;
            btnDays.BackColor = SystemColors.GradientInactiveCaption;
            lblToolName.Text = "Monitoramento de Dias";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            TogglePreviousTool(btnAddition, panAddition);
            panAddition.Visible = true;
            btnAddition.BackColor = SystemColors.GradientInactiveCaption;
            lblToolName.Text = "Adicionar novo Acidente";
        }        

        private void btnAccidents_Click(object sender, EventArgs e)
        {
            TogglePreviousTool(btnAccidents, panAccidents);
            panAccidents.Visible = true;
            btnAccidents.BackColor = SystemColors.GradientInactiveCaption;            
            lblToolName.Text = "Monitoramento de Acidentes";
        }

        private void btnAdditionScreen_Click(object sender, EventArgs e)
        {
            using(var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\sheetbak.xlsx")))
            {
                var sheet = project.Workbook.Worksheets[0];
                SearchService search = new SearchService(sheet);
                Accident accident = search.GetLastAccident("RNEST/MA/EE", 3, 0);
                AccidentAdditionScreen accidentAdditionScreen = new AccidentAdditionScreen(this);
                accidentAdditionScreen.Show();
                Hide();
            }            
        }
    }
}
