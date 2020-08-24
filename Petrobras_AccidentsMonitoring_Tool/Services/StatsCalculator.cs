using Petrobras_AccidentsMonitoring_Tool.Entities;
using Petrobras_AccidentsMonitoring_Tool.Utils;
using Petrobras_AccidentsMonitoring_Tool.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Petrobras_AccidentsMonitoring_Tool.Services
{
    class StatsCalculator
    {

        private static Dictionary<string, Func<IEnumerable<Accident>, IEnumerable<IGrouping<string, Accident>>>> functions;

        static StatsCalculator()
        {
            functions = new Dictionary<string, Func<IEnumerable<Accident>, IEnumerable<IGrouping<string, Accident>>>>
            {
                { "Total Geral", GetBySelfHired },
                { "Empresa", GetByCompany },
                { "Setores", GetSectors },
                { "Anos", GetByYears },
                { "Meses", GetByMonths },
                { "Dias da Semana", GetByWeekDay },
                { "Horas", GetByHour },
                { "Tipos de Lesão", GetByInjure },
                { "Locais", GetByPlace },
                { "Partes do Corpo", GetByBodyPart },
                { "Classificação", GetByGrade },
                { "Classes", GetByClass }
            };
        }

        public static Func<IEnumerable<Accident>, IEnumerable<IGrouping<string, Accident>>> GetFunction(string funcName)
        {
            return functions[funcName];
        }

        public static IEnumerable<string> GetKeys()
        {
            return functions.Keys;
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByAccidentType(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.AccidentType.HasValue).Select(a => new
            {
                AccidentTypeGroup = Utilities.GetTypeGroup(a.AccidentType.Value),
                SelectedAccident = a
            }).GroupBy(x => x.AccidentTypeGroup, a => a.SelectedAccident)
              .OrderByDescending(s => s.Count());
        }

        public static IEnumerable<Accident> TOR(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.AccidentType.Value == AccidentType.Típico);
        }

        public static IEnumerable<Accident> TAR(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.AccidentType.HasValue && a.AccidentType.Value == AccidentType.Típico && a.Class >= 2);
        }

        public static IGrouping<string, Accident> GetByTOR(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.AccidentType.HasValue).Select(a => new
            {
                Ratio = a.AccidentType.Value == AccidentType.Típico ? "TOR" : "Others",
                SelectedAccident = a
            }).GroupBy(x => x.Ratio, x => x.SelectedAccident)
              .OrderByDescending(a => a.Key)
              .First();
        }

        public static IGrouping<string, Accident> GetByTAR(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.AccidentType.HasValue).Select(a => new
            {
                Ratio = a.AccidentType.Value == AccidentType.Típico && a.Class >= 2 ? "TAR" : "Others",
                SelectedAccident = a
            }).GroupBy(x => x.Ratio, x => x.SelectedAccident)
              .OrderByDescending(a => a.Key)
              .First();
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
            return totalAccidents.Select(a => new
            {
                FormattedHour = a.Time.Value.Hours.ToString() + ":00",
                SelectedAccident = a
            }).GroupBy(x => x.FormattedHour, x => x.SelectedAccident).OrderByDescending(s => s.Count());
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
            //return totalAccidents.Select(a => new
            //{
            //    Grade = a.Class <= 2 ? "Sem afastamento" : "Com afastamento",
            //    SelectedAccident = a
            //}).GroupBy(x => x.Grade, x => x.SelectedAccident);
            return totalAccidents.GroupBy(a => a.Grade).OrderBy(s => s.Key);
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
