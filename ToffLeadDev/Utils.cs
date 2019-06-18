using System.Text;
using System.Text.RegularExpressions;

namespace ToffLeadDev
{
    /*
     * Вспомогательный класс со статическими методами.
     */
    public class Utils
    {
        /*
         * Добавление элемента и разделителя в StringBuilder.
         */
        public static void AppendToBuilder(StringBuilder builder, string line, string delimiter)
        {
            builder.Append(line);

            if (delimiter != null)
                builder.Append(delimiter);
        }

        /*
         * Метод определяет, соответствует ли переданная строка какому-либо из шаблонов в переданном массиве.
         */
        public static bool MatchesAny(string value, string[] patterns)
        {
            if (value == null)
                return false;

            if (patterns == null || patterns.Length == 0)
                return true;

            foreach (string pattern in patterns)
                if (Regex.IsMatch(value, pattern))
                    return true;

            return false;
        }

        private Utils() { }
    }
}
