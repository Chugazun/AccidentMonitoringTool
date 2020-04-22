using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value_1 = int.Parse(txtValue_1.Text);
            int value_2 = int.Parse(txtValue_2.Text);

            ChartScreen chartScreen = new ChartScreen();
            chartScreen.Values = new List<int>();
            chartScreen.Values.AddRange(new int[] { value_1, value_2 });
            chartScreen.TotalValue = int.Parse(txtTotalValue.Text);
            chartScreen.Show();
        }
    }
}
