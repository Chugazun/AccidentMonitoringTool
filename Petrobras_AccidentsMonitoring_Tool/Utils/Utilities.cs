using Petrobras_AccidentMonitoring_Tool_Console.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petrobras_AccidentMonitoring_Tool_Console.Utils
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
    }
}
