using System.Globalization;

namespace Petrobras_AccidentMonitoring_Tool_Console.Extensions
{
    static class StringExtensions
    {
        public static string ToTitleCase(this string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }
    }
}
