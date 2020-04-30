using Petrobras_AccidentMonitoring_Tool_Console.Entities;
using Petrobras_AccidentMonitoring_Tool_Console.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class StatsSelector : Form
    {

        private readonly Stats _stats;
        private readonly string _title;

        public StatsSelector()
        {
            InitializeComponent();
        }

        public StatsSelector(string title, Stats stats) : this()
        {
            _stats = stats;
            _title = title;
        }

        private void StatsSelector_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"{_title} - {_stats.StatTag}";
            chkBoxStats.Items.Clear();
            foreach (string key in StatsCalculator.GetKeys().Except(new string[] { _title }))
            {
                chkBoxStats.Items.Add(key);
            }
        }

        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            foreach (var checkedItem in chkBoxStats.CheckedItems)
            {
                string dataTitle = checkedItem.ToString();
                var selectedDataGetter = StatsCalculator.GetFunction(dataTitle);
                ChartScreen chartScreen = new ChartScreen()
                {
                    ResultGroup = selectedDataGetter(_stats.resultList),
                    TotalValue = _stats.resultList.Count(),
                    Title = dataTitle,
                    StatTag = _stats.StatTag
                };
                chartScreen.Show();
            }
            Close();
        }
    }
}
