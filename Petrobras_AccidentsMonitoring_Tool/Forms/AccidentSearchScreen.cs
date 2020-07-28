using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Enums;
using Petrobras_AccidentsMonitoring_Tool.Exceptions;
using Petrobras_AccidentsMonitoring_Tool.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class AccidentSearchScreen : Form
    {
        private readonly MainMenu _mainMenu;
        private IEnumerable<Accident> _results;

        public AccidentSearchScreen()
        {
            InitializeComponent();
        }

        public AccidentSearchScreen(MainMenu mainMenu) : this()
        {
            _mainMenu = mainMenu;
        }

        private void listResults_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(SystemBrushes.Menu, e.Bounds);
            e.Graphics.DrawRectangle(SystemPens.GradientInactiveCaption,
                new Rectangle(e.Bounds.X, 0, e.Bounds.Width, e.Bounds.Height));

            string text = listResults.Columns[e.ColumnIndex].Text;
            TextFormatFlags cFlag = TextFormatFlags.HorizontalCenter
                                  | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(e.Graphics, text, listResults.Font, e.Bounds, Color.Black, cFlag);
        }

        private void listResults_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listResults_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void AccidentSearchScreen_Load(object sender, EventArgs e)
        {
            SetLastColumnToFill(listResults);
            comboType.SelectedIndex = 0;
            comboClass.SelectedIndex = 0;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                listResults.Items.Clear();
                lblResults.Text = "Resultados: ";
                
                using (var project = new ExcelPackage(new System.IO.FileInfo($@"{Properties.Resources.MainSheet}")))
                {
                    var sheet = project.Workbook.Worksheets[0];
                    SearchService searchService = new SearchService(sheet);
                    SearchModel searchModel = GetFormInfo();

                    _results = searchService.AdvSearch(searchModel, ResultType.FullResult);
                }

                foreach (Accident accident in _results)
                {
                    AddResultToTable(accident);
                }

                lblResults.Text += listResults.Items.Count;
                listResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listResults.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
                SetLastColumnToFill(listResults);

            }
            catch (InvalidDateException exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ResultNotFoundException exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            listResults.Items.Clear();
            lblResults.Text = "Resultados: ";
            Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Text = "");            
            dateboxInterval_Initial.Value = new DateTime(2014, 1, 1);
            dateBoxInterval_Final.Value = DateTime.Now;
            dateBoxYear.Value = DateTime.Now;
        }

        private void AddResultToTable(Accident accident)
        {
            ListViewItem item = new ListViewItem
            {
                Text = accident.Company
            };
            item.SubItems.Add(accident.Sector.ToUpper());
            item.SubItems.Add(accident.EmployeeName);
            item.SubItems.Add(accident.Date.Value.ToString(@"dd/MM/yyyy"));
            string accidentClass = accident.Class.HasValue ? accident.Class.Value.ToString() : accident.AccidentType.ToString();
            item.SubItems.Add(accidentClass);
            item.SubItems.Add(accident.InjuryType);
            listResults.Items.Add(item);
        }

        private SearchModel GetFormInfo()
        {
            SearchModel searchModel = new SearchModel()
            {
                Company = GetTextBoxInfo(txtCompany),
                Sector = GetTextBoxInfo(txtSector),
                EmployeeName = GetTextBoxInfo(txtName),
                InjuryType = GetTextBoxInfo(txtInjury)
            };

            if (radioInterval.Checked)
            {
                searchModel.InitialDate = dateboxInterval_Initial.Value;
                searchModel.FinalDate = dateBoxInterval_Final.Value;
            }
            else if (radioYear.Checked)
            {
                searchModel.Year = dateBoxYear.Value.Year;
            }
            else
            {
                searchModel.InitialDate = dateBoxExact.Value;
                searchModel.FinalDate = dateBoxExact.Value;
            }

            if (comboType.SelectedIndex == 0)
            {
                searchModel.Class = comboClass.SelectedIndex > 0 ? (int?)comboClass.SelectedIndex - 1 : null;
                searchModel.AccidentType = AccidentType.Típico;
            }
            else if (comboType.SelectedIndex < 3) searchModel.AccidentType = (AccidentType?)Enum.Parse(typeof(AccidentType), comboType.SelectedItem.ToString());

            return searchModel;
        }

        private void radioInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInterval.Checked) panInterval.BringToFront();
        }

        private void radioYear_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYear.Checked) panYear.BringToFront();
        }

        private void radioExactDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioExactDate.Checked) panExactDate.BringToFront();
        }

        private string GetTextBoxInfo(TextBox textBox)
        {
            return textBox.Text == "" ? null : textBox.Text;
        }

        private void listResults_ItemClick(object sender, EventArgs e)
        {
            AccidentManagementScreen accidentAdditionScreen = new AccidentManagementScreen(this, _results.ElementAt(listResults.SelectedIndices[0]));
            accidentAdditionScreen.Show();
            Hide();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboType.SelectedIndex == 0) panClass.Visible = true;
            else panClass.Visible = false;
        }

        private void AccidentSearchScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
