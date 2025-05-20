using System.Text.RegularExpressions;

namespace Sealed_Static_Extension.Helper
{
    static class ExtentionMethods
    {
        public static bool IsOdd(this int num) => num%2!=0;
        public static bool IsEven(this int num) => num%2==0;
        public static bool IsContainDigit(this string str) => !string.IsNullOrEmpty(str) && Regex.IsMatch(str, @"\d");
        public static string ToCapitalize(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;
            str = str.Trim();
            return char.ToUpperInvariant(str[0]) + str.Substring(1);
        }
        public static int[] GetValueIndexes(this string str, char c)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
                if (str[i] == c) count++;

            int[] indexes = new int[count];

            int index = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == c) indexes[index++] = i;

            return indexes;
        }
        public static string GetFirstSentence(this string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return sentence;
            var parts = sentence.Split('.');
            return parts.Length > 0 ? parts[0].Trim() : sentence;
        }
        public static string GetSecondWord(this string word)
        {
            if (string.IsNullOrWhiteSpace(word)) return string.Empty;
            string[] parts = word.Split(' ');
            return parts[1];
        }
    }
}
