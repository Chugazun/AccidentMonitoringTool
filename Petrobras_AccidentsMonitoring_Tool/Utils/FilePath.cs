using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrobras_AccidentsMonitoring_Tool.Utils
{
    static class FilePath
    {
        public static string Main;
        public static string Test;

        static FilePath()
        {
            Main = @"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\ACOMPANHAMENTO DE ACIDENTES 2020_PAINEL_PROJETO_rev8.xlsx";
            Test = @"E:\Stuff\Studies\c#\Petrobras_AccidentMonitoring_Tool_Console\Petrobras_AccidentMonitoring_Tool_Console\repos\sheetbak.xlsx";
        }
    }
}
