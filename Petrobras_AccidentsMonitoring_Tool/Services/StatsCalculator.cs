using Petrobras_AccidentMonitoring_Tool_Console.Entities;
using Petrobras_AccidentMonitoring_Tool_Console.Utils;
using Petrobras_AccidentsMonitoring_Tool.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petrobras_AccidentMonitoring_Tool_Console.Services
{
    class StatsCalculator
    {

        private static Dictionary<string, Func<IEnumerable<Accident>, IEnumerable<IGrouping<string, Accident>>>> functions;

        static StatsCalculator()
        {
            functions = new Dictionary<string, Func<IEnumerable<Accident>, IEnumerable<IGrouping<string, Accident>>>>();
            functions.Add("Total Geral", GetBySelfHired);
            functions.Add("Empresa", GetByCompany);
            functions.Add("Setores", GetSectors);
            functions.Add("Anos", GetByYears);
            functions.Add("Meses", GetByMonths);
            functions.Add("Dias da Semana", GetByWeekDay);
            functions.Add("Horas", GetByHour);
            functions.Add("Tipos de Lesão", GetByInjure);
            functions.Add("Locais", GetByPlace);
            functions.Add("Partes do Corpo", GetByBodyPart);
            functions.Add("Níveis(Temp)", GetByGrade);
            functions.Add("Classes", GetByClass);
        }

        public static Func<IEnumerable<Accident>, IEnumerable<IGrouping<string, Accident>>> GetFunction(string funcName)
        {
            return functions[funcName];
        }

        public static IEnumerable<string> GetKeys()
        {
            return functions.Keys.Select(k => k);
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByAccidentType(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.AccidentType.ToString()).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<Accident> TOR(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.AccidentType == AccidentType.Típicos);
        }

        public static IEnumerable<Accident> TAR(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.AccidentType == AccidentType.Típicos && a.Class >= 2);
        }

        #region unused GetAmounts Method
        //public static IEnumerable<int> GetAmounts(List<Accident> totalAccidents, params string[] indexes)
        //{
        //    foreach (string index in indexes)
        //    {
        //        Func<List<Accident>, int> resultFunction = functions[index];

        //        yield return resultFunction(totalAccidents);
        //    }
        //    yield return totalAccidents.Count;
        //    use "GetPercentages()" to get the percentages
        //}
        #endregion

        public static double GetPercentages(int total, int value)
        {
            return value / (double)total * 100;
        }

        public static IEnumerable<Accident> GetByPetrobras(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.Company.ToLower() == "petrobras");
        }

        public static IEnumerable<Accident> GetByContratados(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.Company.ToLower() != "petrobras");
        }

        public static IEnumerable<IGrouping<string, Accident>> GetBySelfHired(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Select(a => new
            {
                Type = a.Company.ToLower() == "petrobras" ? a.Company : "Contratada",
                SelectedAccident = a
            }).GroupBy(x => x.Type, x => x.SelectedAccident)
              .OrderByDescending(a => a.Key);
        }

        public static IEnumerable<IGrouping<string, Accident>> GetSectors(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.Sector).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByYears(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.Date.Value.Year.ToString()).OrderBy(s => s.Key);
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByMonths(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => Utilities.ConvertMonth(a.Date.Value.Month)).OrderBy(s => Utilities.ConvertMonth(s.Key));
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByHour(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.Time.Value.Hours.ToString()).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByWeekDay(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.WeekDay).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByCompany(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.Company).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByClass(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Select(a => new
            {
                ClassValue = "Classe " + a.Class,
                SelectedAccident = a
            }).GroupBy(x => x.ClassValue, x => x.SelectedAccident).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByGrade(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Select(a => new
            {
                Grade = a.Class <= 2 ? "Sem afastamento" : "Com afastamento",
                SelectedAccident = a
            }).GroupBy(x => x.Grade, x => x.SelectedAccident);
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByPlace(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.Place).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByInjure(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.InjuryType).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByBodyPart(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.BodyPart).OrderByDescending(s => s.Count());
        }
    }
}
