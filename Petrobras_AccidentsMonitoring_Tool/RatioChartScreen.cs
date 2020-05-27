using Petrobras_AccidentMonitoring_Tool_Console.Entities;
using Petrobras_AccidentMonitoring_Tool_Console.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class RatioChartScreen : Form
    {
        private MainMenu _mainMenu;
        public List<Stats> Stats { get; set; }
        public IEnumerable<IGrouping<string, Accident>> ResultGroup { get; set; }
        public int TotalValue { get; set; }

        public RatioChartScreen()
        {
            InitializeComponent();
        }

        public RatioChartScreen(MainMenu mainMenu) : this()
        {
            _mainMenu = mainMenu;
        }

        private void RatioChartScreen_Load(object sender, EventArgs e)
        {
            statChart.Series.Clear();
            statChart.Legends.Clear();
            statChart.ChartAreas.Clear();
            lblTotal.Text += TotalValue.ToString();
            lblTotalPerType.Text = GetTotalStats();

            statChart.ChartAreas.Add(new ChartArea());

            statChart.Legends.Add("MyLegend");
            statChart.Legends[0].LegendStyle = LegendStyle.Table;
            statChart.Legends[0].Docking = Docking.Bottom;
            statChart.Legends[0].Alignment = StringAlignment.Center;
            statChart.Legends[0].Title = "Dados por Taxa";
            statChart.Legends[0].BorderColor = Color.Black;

            string seriesName = "Test";
            statChart.Series.Add(seriesName);

            statChart.Series[seriesName].ChartType = SeriesChartType.Pie;

            IEnumerable<Accident> tipicalAccidents = ResultGroup.FirstOrDefault(s => s.Key == "Típicos");
            Stats = new List<Stats>() { new Stats("TOR", StatsCalculator.TOR(tipicalAccidents)), new Stats("TAR", StatsCalculator.TAR(tipicalAccidents)) };

            for (int i = 0; i < Stats.Where(s => s.resultList.Count() > 0).ToList().Count; i++)
            {
                int item = Stats[i].resultList.Count();
                statChart.Series[seriesName].Points.AddXY(item, item);
                statChart.Series[seriesName].Points[i].Label = $"{item} ({(item / (double)TotalValue * 100).ToString("0.0")}%)";
                statChart.Series[seriesName].Points[i].LegendText = Stats[i].StatTag + ": " + item;
            }
        }        

        private void statChart_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = statChart.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (hit.PointIndex >= 0 && hit.Series != null)
            {
                Stats resultStats = Stats[hit.PointIndex];

                StatsSelector statsSelector = new StatsSelector("Total de acidentes", resultStats);
                statsSelector.Show();
            }
            else
            {
                lblTotal.Text = "";
            }
        }
        private string GetTotalStats()
        {
            StringBuilder sb = new StringBuilder();
            //var selectedGroup = ResultGroup.FirstOrDefault(g => g.Key == "Típicos");
            //if (selectedGroup != null) sb.AppendLine($"- Típicos: {selectedGroup.Count()}");

            //selectedGroup = ResultGroup.FirstOrDefault(g => g.Key == "Trajeto");
            //if (selectedGroup != null) sb.AppendLine($"- Trajeto: {selectedGroup.Count()}");

            //selectedGroup = ResultGroup.FirstOrDefault(g => g.Key == "Equiparados");
            //if (selectedGroup != null) sb.AppendLine($"- Equiparados: {selectedGroup.Count()}");

            foreach (var type in ResultGroup)
            {
                if (type != null) sb.AppendLine($"- {type.Key}: {type.Count()}");
            }

            return sb.ToString();
        }

        private void RatioChartScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.WindowState = FormWindowState.Normal;
        }
    }
}
