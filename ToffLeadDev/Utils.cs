using System.Text;
using System.Text.RegularExpressions;
using System;

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

        /*
         * Метод удаляет из переданной строки все указанные в переданном массиве символы и возвращает полученную строку.
         */
        public static string RemoveChars(string value, char[] outChars)
        {
            if (value == null || value.Length == 0 || outChars == null || outChars.Length == 0)
                return null;

            char[] valueChars = value.ToCharArray();
            StringBuilder builder = new StringBuilder();

            bool[] presentChars = new bool[65536];
            foreach (char outChar in outChars)
                presentChars[(int)outChar] = true;

            foreach (char valueChar in valueChars)
                if (!presentChars[(int)valueChar])
                    builder.Append(valueChar);

            return builder.ToString();
        }

        /*
         * Метод удаляет из переданной строки все, кроме цифр, и возвращает полученную строку.
         */
        public static string RemoveAllButDigits(string value)
        {
            if (value == null || value.Length == 0)
                return null;

            char[] valueChars = value.ToCharArray();
            StringBuilder builder = new StringBuilder();

            foreach (char valueChar in valueChars)
                if (Char.IsDigit(valueChar))
                    builder.Append(valueChar);

            return builder.ToString();
        }

        private Utils() { }
    }
}
