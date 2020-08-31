using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class RatioChartScreen : Form
    {
        private MainMenu _mainMenu;
        public IEnumerable<Accident> Result { get; set; }
        public Dictionary<string, IEnumerable<IGrouping<string, Accident>>> ResultLists { get; set; }
        public int TotalValue { get; set; }

        public RatioChartScreen()
        {
            InitializeComponent();
        }

        public RatioChartScreen(MainMenu mainMenu) : this()
        {
            _mainMenu = mainMenu;
        }

        private void ChartSetup()
        {
            statChart.Series.Clear();
            statChart.Legends.Clear();
            statChart.ChartAreas.Clear();
            lblTotal.Text += TotalValue.ToString();
            lblTotalPerType.Text = GetTotalStats();

            statChart.ChartAreas.Add(new ChartArea());

            statChart.Legends.Add("RatioChartLegend");
            statChart.Legends[0].LegendStyle = LegendStyle.Table;
            statChart.Legends[0].Docking = Docking.Bottom;
            statChart.Legends[0].Alignment = StringAlignment.Center;
            statChart.Legends[0].Title = "Dados por Taxa";
            statChart.Legends[0].BorderColor = Color.Black;

            statChart.ChartAreas[0].AxisX.LabelStyle.Angle = 60;
            statChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Consolas", 9f);
            statChart.ChartAreas[0].AxisX.Interval = 1;
            statChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            statChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
        }

        private void RatioChartScreen_Load(object sender, EventArgs e)
        {
            //470; 488 original size         

            ChartSetup();

            string torSeriesName = "TOR";
            string tarSeriesName = "TAR";
            statChart.Series.Add(torSeriesName);
            statChart.Series.Add(tarSeriesName);

            statChart.Series[torSeriesName].ChartType = SeriesChartType.Column;
            statChart.Series[torSeriesName].IsValueShownAsLabel = true;
            statChart.Series[tarSeriesName].ChartType = SeriesChartType.Column;
            statChart.Series[tarSeriesName].IsValueShownAsLabel = true;

            //IEnumerable<Accident> tipicalAccidents = ResultGroup.FirstOrDefault(s => s.Key == "Típicos");

            IGrouping<string, Accident> torList = StatsCalculator.GetByTOR(Result);
            IGrouping<string, Accident> tarList = StatsCalculator.GetByTAR(Result);


            var resultsByMonth = StatsCalculator.GetByMonths(torList);
            string[] x = resultsByMonth.Select(g => g.Key).Prepend("Total").ToArray();
            int[] y = resultsByMonth.Select(g => g.Count()).Prepend(torList.Count()).ToArray();

            statChart.Series[torSeriesName].Points.DataBindXY(x, y);

            var resultsByMonthTar = StatsCalculator.GetByMonths(tarList);
            string[] xt = resultsByMonthTar.Select(g => g.Key).Prepend("Total").ToArray();
            int[] yt = resultsByMonthTar.Select(g => g.Count()).Prepend(tarList.Count()).ToArray();

            ResultLists = new Dictionary<string, IEnumerable<IGrouping<string, Accident>>>();
            ResultLists.Add(torSeriesName, resultsByMonth.Prepend(torList));
            ResultLists.Add(tarSeriesName, resultsByMonthTar.Prepend(tarList));

            statChart.Series[tarSeriesName].Points.DataBindXY(xt, yt);

            statChart.AlignDataPointsByAxisLabel();

            //for (int i = 0; i < Stats.Where(s => s.resultList.Count() > 0).ToList().Count; i++)
            //{
            //    int item = Stats[i].resultList.Count();
            //    statChart.Series[seriesName].Points.AddXY(item, item);
            //    statChart.Series[seriesName].Points[i].Label = $"{item} ({(item / (double)TotalValue * 100).ToString("0.0")}%)";
            //    statChart.Series[seriesName].Points[i].LegendText = Stats[i].StatTag + ": " + item;
            //}
        }

        private void statChart_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = statChart.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (hit.PointIndex >= 0 && hit.Series != null)
            {

                Stats resultStats = GetStats(hit.Series.Name, hit.PointIndex);

                StatsSelector statsSelector = new StatsSelector(hit.Series.Name, resultStats);
                statsSelector.Show();
            }
        }
        private string GetTotalStats()
        {
            StringBuilder sb = new StringBuilder();

            var resultByType = StatsCalculator.GetByAccidentType(Result);

            foreach (var type in resultByType)
            {
                if (type != null) sb.AppendLine($"- {type.Key}: {type.Count()}");
            }

            return sb.ToString();
        }

        private Stats GetStats(string seriesName, int hitIndex)
        {
            string searchParameter = statChart.Series[seriesName].Points[hitIndex].AxisLabel;

            var seriesResult = ResultLists[seriesName];

            IEnumerable<Accident> result = seriesResult.FirstOrDefault(g => g.Key == searchParameter);

            if (result == null) result = seriesResult.First();

            return new Stats(searchParameter, result);
        }

        private void RatioChartScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.WindowState = FormWindowState.Normal;
        }
    }
}
