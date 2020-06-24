using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Services;
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
    public partial class AccidentSearchScreen : Form
    {
        public AccidentSearchScreen()
        {
            InitializeComponent();
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(SystemBrushes.Menu, e.Bounds);
            e.Graphics.DrawRectangle(SystemPens.GradientInactiveCaption,
                new Rectangle(e.Bounds.X, 0, e.Bounds.Width, e.Bounds.Height));

            string text = listResults.Columns[e.ColumnIndex].Text;
            TextFormatFlags cFlag = TextFormatFlags.HorizontalCenter
                                  | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(e.Graphics, text, listResults.Font, e.Bounds, Color.Black, cFlag);
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void AccidentSearchScreen_Load(object sender, EventArgs e)
        {
            SetLastColumnToFill(listResults);

        }

        private void SetLastColumnToFill(ListView lv)
        {
            int sum = 0;
            int count = lv.Columns.Count;
            for (int i = 0; i < count - 1; i++)
            {
                sum += lv.Columns[i].Width;
            }
            lv.Columns[count - 1].Width = lv.ClientSize.Width - sum;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            IEnumerable<Accident> result;
            using (var project = new ExcelPackage(new System.IO.FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\ACOMPANHAMENTO DE ACIDENTES 2020_PAINEL_PROJETO_rev8.xlsx")))
            {
                var sheet = project.Workbook.Worksheets[0];
                SearchService searchService = new SearchService(sheet);
                SearchModel searchModel = new SearchModel()
                {
                    Sector = "RNEST/OP/UT"
                };
                result = searchService.AdvSearch(searchModel);
            }

            ListViewItem item;
            foreach (Accident accident in result)
            {
                item = new ListViewItem();
                item.Text = accident.Company;
                item.SubItems.Add(accident.Sector);
                item.SubItems.Add(accident.EmployeeName);
                listResults.Items.Add(item);
            }
            lblResults.Text += listResults.Items.Count;
            listResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            SetLastColumnToFill(listResults);
        }
    }
}
