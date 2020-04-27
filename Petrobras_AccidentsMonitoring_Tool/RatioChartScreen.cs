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
        public List<int> Values { get; set; }
        public List<Stats> Stats { get; set; }
        public int TotalValue { get; set; }
        public RatioChartScreen()
        {
            InitializeComponent();
        }

        private void RatioChartScreen_Load(object sender, EventArgs e)
        {
            statChart.Series.Clear();
            statChart.Legends.Clear();
            statChart.ChartAreas.Clear();
            lblTotal.Text += TotalValue.ToString();

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

            for (int i = 0; i < Stats.Count; i++)
            {
                int item = Stats[i].resultList.Count();
                statChart.Series[seriesName].Points.AddXY(item, item);
                statChart.Series[seriesName].Points[i].Label = $"{item} ({(item / (double)TotalValue * 100).ToString("0.0")}%)";
                statChart.Series[seriesName].Points[i].LegendText = Stats[i].StatTag + ": " + item;
            }
        }

        private void lblTotal_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void statChart_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = statChart.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (hit.PointIndex >= 0 && hit.Series != null)
            {
                DataPoint dp = statChart.Series[0].Points[hit.PointIndex];
                Stats resultStats = Stats[hit.PointIndex];
                ChartScreen chartScreen = new ChartScreen()
                {
                    ResultGroup = StatsCalculator.GetBySelfHired(resultStats.resultList),
                    TotalValue = resultStats.resultList.Count(),
                    Title = "Total Geral",
                    StatTag = resultStats.StatTag
                };

                chartScreen.Show();
            }
            else
            {
                lblTotal.Text = "";
            }
        }
    }
}
