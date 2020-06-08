using System.Globalization;

namespace Petrobras_AccidentsMonitoring_Tool.Extensions
{
    static class StringExtensions
    {
        public static string ToTitleCase(this string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }
    }
}
