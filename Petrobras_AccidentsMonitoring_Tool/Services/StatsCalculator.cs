using Petrobras_AccidentMonitoring_Tool_Console.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petrobras_AccidentMonitoring_Tool_Console.Services
{
    class StatsCalculator
    {

        private static Dictionary<string, Func<List<Accident>, int>> functions;

        static StatsCalculator()
        {
            functions = new Dictionary<string, Func<List<Accident>, int>>();
            //functions.Add("petrobras", GetByPetrobras);
            //functions.Add("Contratados", GetByContratados);
        }

        public static IEnumerable<Accident> TOR(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.Class != null);
        }

        public static IEnumerable<Accident> TAR(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.Where(a => a.Class != null && a.Class >= 2);
        }

        public static IEnumerable<int> GetAmounts(List<Accident> totalAccidents, params string[] indexes)
        {
            foreach (string index in indexes)
            {
                Func<List<Accident>, int> resultFunction = functions[index];

                yield return resultFunction(totalAccidents);
            }
            yield return totalAccidents.Count;
            //use "GetPercentages()" to get the percentages
        }

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
            return totalAccidents.GroupBy(a => a.Date.Value.Month.ToString()).OrderByDescending(s => s.Key);
        }

        public static IEnumerable<IGrouping<int, Accident>> GetByHour(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.Time.Value.Hours).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByWeekDay(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.WeekDay).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<string, Accident>> GetByCompany(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.Company).OrderByDescending(s => s.Count());
        }

        public static IEnumerable<IGrouping<int, Accident>> GetByClass(IEnumerable<Accident> totalAccidents)
        {
            return totalAccidents.GroupBy(a => a.Class.Value).OrderByDescending(s => s.Count());
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
