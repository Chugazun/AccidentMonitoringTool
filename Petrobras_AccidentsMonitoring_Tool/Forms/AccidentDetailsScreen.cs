using Petrobras_AccidentsMonitoring_Tool.Entities;
using System;
using System.Windows.Forms;

namespace Petrobras_AccidentsMonitoring_Tool
{
    public partial class AccidentDetailsScreen : Form
    {
        private readonly Accident _accident;

        public AccidentDetailsScreen()
        {
            InitializeComponent();
        }

        public AccidentDetailsScreen(Accident accident) : this()
        {
            _accident = accident;
        }

        private void AccidentDetailsScreen_Load(object sender, EventArgs e)
        {
            txtCompany.Text = _accident.Company;
            txtSector.Text = _accident.Sector;
            txtName.Text = _accident.EmployeeName;
            txtJobRole.Text = _accident.JobRole;
            txtDate.Text = _accident.Date.Value.ToString(@"dd/MM/yyyy");
            txtWeekDay.Text = _accident.WeekDay;
            txtTime.Text = _accident.Time.Value.ToString(@"hh\:mm");
            txtClass.Text = _accident.Class.Value.ToString();
            txtPlace.Text = _accident.Place;
            txtBodyPart.Text = _accident.BodyPart;
            txtInjuryType.Text = _accident.InjuryType;
            txtDescription.Text = _accident.Description;
        }
    }
}
