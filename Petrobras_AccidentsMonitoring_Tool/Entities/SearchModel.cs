using System;
using System.Collections.Generic;
using System.Text;

namespace Petrobras_AccidentsMonitoring_Tool.Entities
{
    class SearchModel
    {
        public int? Class { get; set; }
        public int? Year { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public string Company { get; set; }
        public string Sector { get; set; }
        public string EmployeeName { get; set; }
        public string InjuryType { get; set; }
    }
}
