using Petrobras_AccidentsMonitoring_Tool.Exceptions;
using Petrobras_AccidentsMonitoring_Tool.Extensions;
using Petrobras_AccidentsMonitoring_Tool.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petrobras_AccidentsMonitoring_Tool.Entities
{
    public class Accident
    {
        private int? _class;
        private string _company, _sector, _supervisor, _employeeName, _jobRole, _weekDay, _place, _injuryType, _bodyPart, _rta, _rpa, _cat;

        public int? Class
        {
            get => _class.HasValue ? _class.Value : (int?)null;
            set
            {
                if (value < 0 || value > 5) throw new AccidentClassException($"Número de classe inválido ({value})");
                _class = value;
                SetGrade();
            }
        }
        public int ID { get; private set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string Company { get => _company; set => _company = SetValue(value); }
        public string Sector { get => _sector; set => _sector = SetValue(value); }
        public string Supervisor { get => _supervisor; set => _supervisor = SetValue(value); }
        public string EmployeeName { get => _employeeName; set => _employeeName = SetValue(value); }
        public string JobRole { get => _jobRole; set => _jobRole = SetValue(value); }
        public string WeekDay
        {
            get => _weekDay; set
            {
                string aux = SetValue(value);
                _weekDay = aux.Contains("-") ? aux.Substring(0, aux.IndexOf("-")) : aux;
            }
        }
        public string Place { get => _place; set => _place = SetValue(value); }
        public string InjuryType { get => _injuryType; set => _injuryType = SetValue(value); }
        public string BodyPart { get => _bodyPart; set => _bodyPart = SetValue(value); }
        public string RTA { get => _rta; set => _rta = SetValue(value); }
        public string RPA { get => _rpa; set => _rpa = SetValue(value); }
        public string CAT { get => _cat; set => _cat = SetValue(value); }
        public string Grade { get; set; }
        public AccidentType AccidentType { get; set; }
        public string Description { get; set; }

        public Accident()
        {

        }

        public Accident(int id)
        {
            ID = id;
        }

        private string SetValue(string input) => !(input == "") ? input.ToLower().ToTitleCase().Trim() : "N/A";
        private void SetGrade() => Grade = _class.HasValue && _class.Value <= 2 ? "Sem Afastamento" : "Com Afastamento";
    }
}
