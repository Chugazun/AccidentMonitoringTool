using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Extensions;
using Petrobras_AccidentsMonitoring_Tool.Services;
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
    public partial class AccidentAdditionScreen : Form
    {
        public AccidentAdditionScreen()
        {
            InitializeComponent();
        }

        private bool focus = false;

        private void AccidentAdditionScreen_Load(object sender, EventArgs e)
        {
            ScreenSetup();

        }

        private void ScreenSetup()
        {
            dateTimeBox.Value = DateTime.Today;
        }

        private string GetWeekDay()
        {
            var ptCulture = new System.Globalization.CultureInfo("pt-BR");
            string day = ptCulture.DateTimeFormat.GetDayName(dateTimeBox.Value.DayOfWeek);
            return day.Contains("-") ? day.Substring(0, day.IndexOf("-")).ToTitleCase() : day.ToTitleCase();
        }

        private void dateTimeBox_ValueChanged(object sender, EventArgs e)
        {
            txtWeekDay.Text = GetWeekDay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            focus = true;
            if (VerifyRequiredControls())
            {
                using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\sheetbak.xlsx")))
                {
                    ExcelWorksheet sheet = project.Workbook.Worksheets[0];
                    ManagementService managementService = new ManagementService(sheet);
                    Accident accident = new Accident()
                    {
                        Company = txtCompany.Text,
                        Sector = txtSector.Text,
                        EmployeeName = txtName.Text,
                        JobRole = txtJobRole.Text,
                        Date = dateTimeBox.Value,
                        WeekDay = txtWeekDay.Text,
                        Time = TimeSpan.Parse(hourBox.Value.TimeOfDay.ToString()),
                        Class = int.Parse(comboClass.SelectedItem.ToString()),
                        Place = txtPlace.Text,
                        BodyPart = txtBodyPart.Text,
                        InjuryType = txtInjuryType.Text,
                        Description = txtDescription.Text
                    };

                    managementService.AddAccident(accident);
                    project.Save();
                }
            }
            else
            {
                //MessageBox.Show("Todos os campos não opcionais devem ser preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyRequiredControls()
        {
            int txtBoxCount = groupGenInfo.Controls.OfType<TextBox>().Where(tb => tb.Text.Trim() == "").Count() + groupAccidentInfo.Controls.OfType<TextBox>().Where(tb => tb.Text.Trim() == "").Count();
            if (comboClass.SelectedIndex != 0 && txtBoxCount == 0) return true;
            else
            {
                txtDescription.Text = txtBoxCount.ToString();
                return false;
            }
        }

        private void AccidentAdditionScreen_Paint(object sender, PaintEventArgs e)
        {
            if (focus)
            {
                PaintBorders(groupGenInfo.Controls.OfType<TextBox>().Where(tb => tb.Text == ""), e);
                PaintBorders(groupAccidentInfo.Controls.OfType<TextBox>().Where(tb => tb.Text == ""), e);
            }
        }

        private void PaintBorders(IEnumerable<TextBox> textBoxes, PaintEventArgs e)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 1;
                g.DrawRectangle(p, new Rectangle(textBox.Location.X - variance, textBox.Location.Y - variance, textBox.Width + variance, textBox.Height + variance));
            }
        }
    }
}
