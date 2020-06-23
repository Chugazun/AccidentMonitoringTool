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

        private readonly MainMenu _mainMenu;
        private bool isEditMode;
        private int row;

        public AccidentAdditionScreen(MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        public AccidentAdditionScreen(MainMenu mainMenu, Accident accident) : this(mainMenu)
        {
            row = accident.ID;
            txtCompany.Text = accident.Company;
            txtSector.Text = accident.Sector;
            txtName.Text = accident.EmployeeName;
            txtJobRole.Text = accident.JobRole;
            dateTimeBox.Value = accident.Date.Value;
            txtWeekDay.Text = accident.WeekDay;
            hourBox.Value = DateTime.Parse($"01/01/1753 {accident.Time.Value.ToString()}");
            comboClass.SelectedIndex = accident.Class.Value + 1;
            txtPlace.Text = accident.Place;
            txtBodyPart.Text = accident.BodyPart;
            txtInjuryType.Text = accident.InjuryType;
            txtDescription.Text = accident.Description;            
            isEditMode = true;
        }

        private void AccidentAdditionScreen_Load(object sender, EventArgs e)
        {
            ScreenSetup();
        }

        private void ScreenSetup()
        {
            if (!isEditMode)
            {
                dateTimeBox.Value = DateTime.Today;
                comboClass.SelectedIndex = 0;
            }
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (VerifyRequiredControls())
            {
                using (var project = new ExcelPackage(new FileInfo(@"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\sheetbak.xlsx")))
                {
                    ExcelWorksheet sheet = project.Workbook.Worksheets[0];
                    ManagementService managementService = new ManagementService(sheet);
                    Accident accident = new Accident(row)
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
                        Description = txtDescription.Text,
                        RTA = txtRTA.Text,
                        CAT = txtCAT.Text
                    };
                    if (!isEditMode) managementService.AddAccident(accident);
                    else managementService.EditAccident(accident);
                    project.Save();
                    _mainMenu.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Todos os campos não opcionais devem ser preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyRequiredControls()
        {
            int txtBoxCount = groupGenInfo.Controls.OfType<TextBox>().Where(tb => tb.Text.Trim() == "").Count() + groupAccidentInfo.Controls.OfType<TextBox>().Where(tb => tb.Text.Trim() == "").Count();
            if (comboClass.SelectedIndex != 0 && txtBoxCount <= 0) return true;
            else
            {
                return false;
            }
        }

        private void AccidentAdditionScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainMenu.Show();
            Hide();
        }

        private void hourBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
