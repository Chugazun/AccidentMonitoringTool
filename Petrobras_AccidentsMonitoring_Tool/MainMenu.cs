using OfficeOpenXml;
using Petrobras_AccidentMonitoring_Tool_Console.Entities;
using Petrobras_AccidentMonitoring_Tool_Console.Exceptions;
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
    public partial class MainMenu : Form
    {
        private ExcelWorksheet _sheet;
        private SearchService _search;
        private IEnumerable<string> _years;
        private bool isLoaded;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\ACOMPANHAMENTO DE ACIDENTES 2020_PAINEL_PROJETO_rev4.xlsx")))
            {
                _sheet = project.Workbook.Worksheets[0];
                _search = new SearchService(_sheet);
                GetSheetYears(_search.GetYearsColumn().GroupBy(c => c).Select(g => g.Key));
                comboInitialYear.Items.AddRange(_years.Prepend("").ToArray());
                comboInitialYear.SelectedIndex = 1;
                comboFinalYear.Items.AddRange(_years.Prepend("").ToArray());
                comboFinalYear.SelectedIndex = comboFinalYear.Items.Count - 1;
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

                SearchModel searchDetails = new SearchModel()
                {
                    InitialDate = comboInitialYear.SelectedItem.ToString() != "" ? DateTime.Parse(comboInitialYear.SelectedItem + "/01/01") : (DateTime?)null,
                    FinalDate = comboFinalYear.SelectedItem.ToString() != "" ? DateTime.Parse(comboFinalYear.SelectedItem + "/12/31") : (DateTime?)null,
                };

                try
                {
                    IEnumerable<Accident> result = _search.AdvSearch(searchDetails);

                    IEnumerable<Accident> torList = StatsCalculator.TOR(result);
                    IEnumerable<Accident> tarList = StatsCalculator.TAR(result);

                    RatioChartScreen ratioChartScreen = new RatioChartScreen()
                    {
                        Stats = new List<Stats>() { new Stats("TOR", torList), new Stats("TAR", tarList) },
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

        private void ComboBoxSelectionChanged(ComboBox box_1, ComboBox box_2)
        {
            string currentItem = box_2.SelectedItem != null ? box_2.SelectedItem.ToString() : "";
            if (box_1.SelectedIndex > 1)
            {
                if (box_2.SelectedItem.ToString() != "" && int.Parse(box_2.SelectedItem.ToString()) < int.Parse(box_1.SelectedItem.ToString()))
                {
                    box_2.SelectedIndex = 0;
                }
                box_2.Items.Clear();
                box_2.Items.AddRange(_years.Where(y => int.Parse(y) >= int.Parse(box_1.SelectedItem.ToString())).Prepend("").ToArray());
                box_2.SelectedItem = box_2.Items.Contains(currentItem) ? currentItem : "";
            }
            else if (box_2.Items.Count > 0)
            {
                box_2.Items.Clear();
                box_2.Items.AddRange(_years.Prepend("").ToArray());
                box_2.SelectedItem = box_2.Items.Contains(currentItem) ? currentItem : "";
            }
        }
    }
}
