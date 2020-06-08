using Petrobras_AccidentsMonitoring_Tool.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petrobras_AccidentsMonitoring_Tool.Utils
{
    static class Utilities
    {
        public static int ConvertMonth(string month)
        {
            return (int)Enum.Parse(typeof(Months), month);
        }

        public static string ConvertMonth(int monthId)
        {
            Months aux = (Months)monthId;
            return aux.ToString();
        }

        public static string FindMonth(string sheetMonth)
        {
            string[] monthList = new string[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            return monthList.FirstOrDefault(month => month.ToLower().Contains(sheetMonth.ToLower()));
        }

        public static DateTime ConvertToDate(int days)
        {
            TimeSpan t = new TimeSpan(days + 1, 0, 0, 0, 0);
            return DateTime.Now.Subtract(t);
        }

        public static int GetDaysInterval(DateTime date)
        {
            TimeSpan diff = DateTime.Now.Subtract(date);
            return diff.Days - 1;
        }

        public static string GetTypeGroup(AccidentType accidentType)
        {
            switch ((int)accidentType)
            {
                case 1:
                    return "Típicos";

                case 2:
                    return "Trajeto";

                case 3:
                    return "Equiparados";

                default:
                    return "Não Encontrados";
            }
        }
    }
}
