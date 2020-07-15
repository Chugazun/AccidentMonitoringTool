using OfficeOpenXml;
using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Enums;
using Petrobras_AccidentsMonitoring_Tool.Extensions;
using Petrobras_AccidentsMonitoring_Tool.Services;
using Petrobras_AccidentsMonitoring_Tool.Utils;
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

        private readonly Form _mainMenu;
        private bool isEditMode;
        private int row;

        public AccidentAdditionScreen(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        public AccidentAdditionScreen(Form mainMenu, Accident accident) : this(mainMenu)
        {
            row = accident.ID;
            txtCompany.Text = accident.Company;
            txtSector.Text = accident.Sector;
            txtName.Text = accident.EmployeeName;
            txtJobRole.Text = accident.JobRole;
            dateTimeBox.Value = accident.Date.Value;
            txtWeekDay.Text = accident.WeekDay;
            hourBox.Value = DateTime.Parse($"01/01/1753 {accident.Time.Value.ToString()}");
            SetTypeComboBoxes(accident);
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
                comboType.SelectedIndex = 0;
                comboClass.SelectedIndex = 0;
                comboGrade.SelectedIndex = 0;
            }
            else
            {
                Text = "Editar Acidente";
            }
        }

        private void SetTypeComboBoxes(Accident accident)
        {
            switch (accident.AccidentType)
            {
                case AccidentType.Típico:
                    comboType.SelectedIndex = 0;                   
                    comboClass.SelectedIndex = accident.Class.Value + 1;
                    break;

                case AccidentType.Trajeto:
                    comboType.SelectedIndex = 1;
                    comboGrade.SelectedItem = accident.Grade;
                    break;

                case AccidentType.Equiparado:
                    comboType.SelectedIndex = 2;
                    comboGrade.SelectedItem = accident.Grade;
                    break;
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
                using (var project = new ExcelPackage(new FileInfo($@"{Properties.Resources.BackupSheet}")))
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
                        AccidentType = (AccidentType?)Enum.Parse(typeof(AccidentType), comboType.SelectedItem.ToString()),
                        Class = comboType.SelectedIndex == 0 ? (int?)int.Parse(comboClass.SelectedItem.ToString()) : null,
                        Grade = comboType.SelectedIndex != 0 ? comboGrade.SelectedItem.ToString() : null,
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
            if (ComboBoxesSelected() && txtBoxCount <= 0) return true;
            else
            {
                return false;
            }
        }

        private bool ComboBoxesSelected()
        {
            if (comboType.SelectedIndex == 0) return comboClass.SelectedIndex != 0;
            else return comboGrade.SelectedIndex != 0;
        }

        private void AccidentAdditionScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainMenu.Show();            
        }

        private void hourBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboType.SelectedIndex == 0) panClass.BringToFront();
            else panGrade.BringToFront();
        }
    }
}
