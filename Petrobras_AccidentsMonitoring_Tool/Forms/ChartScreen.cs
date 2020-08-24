using Petrobras_AccidentsMonitoring_Tool.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class ChartScreen : Form
    {
        public IEnumerable<IGrouping<string, Accident>> ResultGroup { get; set; }
        public int TotalValue { get; set; }
        public string Title { get; set; }
        public string StatTag { get; set; }

        public ChartScreen()
        {
            InitializeComponent();
        }

        private void ChartScreen_Load(object sender, EventArgs e)
        {
            //470; 488 original size
            statChart.Series.Clear();
            statChart.Legends.Clear();
            statChart.ChartAreas.Clear();
            lblTotal.Text += TotalValue.ToString();

            statChart.ChartAreas.Add(new ChartArea());

            statChart.Legends.Add("ChartInfo");
            statChart.Legends[0].LegendStyle = LegendStyle.Table;
            statChart.Legends[0].Docking = Docking.Bottom;
            statChart.Legends[0].Alignment = StringAlignment.Center;
            statChart.Legends[0].Title = $"Dados por {Title} ({StatTag})";
            statChart.Legends[0].BorderColor = Color.Black;

            string seriesName = "ResultChart";
            statChart.Series.Add(seriesName);

            statChart.Series[seriesName].ChartType = SeriesChartType.Pie;
            //statChart.Series[seriesName].IsValueShownAsLabel = true;
            //string[] x = ResultGroup.Select(g => g.Key).ToArray();
            //int[] y = ResultGroup.Select(g => g.Count()).ToArray();

            //statChart.Series[seriesName].Points.DataBindXY(x, y);

            //statChart.ChartAreas[0].AxisX.LabelStyle.Angle = 60;
            //statChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Consolas", 9f);
            //statChart.ChartAreas[0].AxisX.Interval = 1;
            //statChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            for (int i = 0; i < ResultGroup.Count(); i++)
            {
                int item = ResultGroup.ElementAt(i).Count();
                if (item > 0)
                {
                    statChart.Series[seriesName].Points.AddXY(ResultGroup.ElementAt(i).Key, item);
                    statChart.Series[seriesName].Points[i].Label = $"{item} ({(item / (double)TotalValue * 100).ToString("0.0")}%)";
                    statChart.Series[seriesName].Points[i].LegendText = ResultGroup.ElementAt(i).Key + ": " + item;
                }
            }
            statChart.Series[seriesName]["PieLabelStyle"] = "Outside";
            statChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            statChart.ChartAreas[0].Area3DStyle.Inclination = 0;
        }

        private void statChart_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = statChart.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (hit.PointIndex >= 0 && hit.Series != null)
            {
                Stats resultStats = new Stats(ResultGroup.ElementAt(hit.PointIndex).Key, ResultGroup.ElementAt(hit.PointIndex));

                StatsSelector statsSelector = new StatsSelector(Title, resultStats);
                statsSelector.Show();
            }
        }
    }
}
