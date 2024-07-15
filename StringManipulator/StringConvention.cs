using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace StringManipulator
{
    public class StringConvention
    {
        internal static string ToCamelCase(string input)
        {
            string[] words = input.Split(new[] { ' ', '_', '-' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0) return input;

            StringBuilder sb = new StringBuilder();
            sb.Append(words[0].ToLower());

            for (int i = 1; i < words.Length; i++)
            {
                sb.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i].ToLower()));
            }

            return sb.ToString();
        }

        internal static string ToPascalCase(string input)
        {
            string[] words = input.Split(new[] { ' ', '_', '-' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                sb.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower()));
            }

            return sb.ToString();
        }

        internal static string ToSnakeCase(string input)
        {
            string[] words = input.Split(new[] { ' ', '_', '-' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join("_", words).ToLower();
        }

        internal static string ToKebabCase(string input)
        {
            string[] words = input.Split(new[] { ' ', '_', '-' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join("-", words).ToLower();
        }

        internal static string ToTitleCase(string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        internal static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        internal static string RemoveVowels(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        internal static string ReplaceSpaces(string input, char replacement)
        {
            return input.Replace(' ', replacement);
        }
    }
}
