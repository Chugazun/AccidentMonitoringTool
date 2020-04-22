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
    public partial class ChartScreen : Form
    {

        public List<int> Values { get; set; }
        public int TotalValue { get; set; }

        public ChartScreen()
        {
            InitializeComponent();
        }

        private void ChartScreen_Load(object sender, EventArgs e)
        {
            statChart.Series.Clear();
            statChart.Legends.Clear();
            statChart.ChartAreas.Clear();

            statChart.ChartAreas.Add(new ChartArea());

            statChart.Legends.Add("MyLegend");
            statChart.Legends[0].LegendStyle = LegendStyle.Table;
            statChart.Legends[0].Docking = Docking.Bottom;
            statChart.Legends[0].Alignment = StringAlignment.Center;
            statChart.Legends[0].Title = "MyTitle";
            statChart.Legends[0].BorderColor = Color.Black;

            string seriesName = "Test";
            statChart.Series.Add(seriesName);

            statChart.Series[seriesName].ChartType = SeriesChartType.Pie;

            for (int i = 0; i < Values.Count; i++)
            {
                int item = Values[i];
                statChart.Series[seriesName].Points.AddXY(item, item);
                statChart.Series[seriesName].Points[i].Label = $"{item} ({(item / (double)TotalValue * 100).ToString("0.0")}%)";
                statChart.Series[seriesName].Points[i].LegendText = "Value_" + item;
            }


            //statChart.Series[seriesName]["PieLabelStyle"] = "Disabled";
        }

        private void statChart_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = statChart.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if(hit.PointIndex >= 0 && hit.Series != null)
            {
                DataPoint dp = statChart.Series[0].Points[hit.PointIndex];
                ChartScreen chartScreen = new ChartScreen();
                chartScreen.TotalValue = (int)dp.XValue;
                chartScreen.Values = new List<int>();
                int tempVal = chartScreen.TotalValue - new Random().Next((int)Math.Floor((double)chartScreen.TotalValue / 2));
                chartScreen.Values.AddRange(new int[] { tempVal, chartScreen.TotalValue - tempVal });
                chartScreen.Show();
            } else
            {
                lblTest.Text = "";
            }
            
        }
    }
}
