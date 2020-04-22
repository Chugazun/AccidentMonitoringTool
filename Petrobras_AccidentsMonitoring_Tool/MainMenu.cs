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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
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
                SearchService search = new SearchService(_sheet);

                SearchModel searchDetails = new SearchModel()
                {
                    InitialDate = DateTime.Parse("2014/01/01"),
                    //FinalDate = DateTime.Parse("2014/02/14"),
                };

                try
                {
                    IEnumerable<Accident> result = search.AdvSearch(searchDetails);

                    IEnumerable<Accident> torList = StatsCalculator.TOR(result);
                    IEnumerable<Accident> tarList = StatsCalculator.TAR(result);

                    RatioChartScreen ratioChartScreen = new RatioChartScreen()
                    {
                        Stats = new List<Stats>() { new Stats("TOR", torList), new Stats("TAR", tarList) },
                        TotalValue = result.Count()
                    };

                    ratioChartScreen.Show();
                }
                catch (ResultNotFoundException)
                {
                    lblNoResults.Visible = true;
                }
            }
        }
    }
}
