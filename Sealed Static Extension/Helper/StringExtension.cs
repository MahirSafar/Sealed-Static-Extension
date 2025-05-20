namespace Sealed_Static_Extension.Helper
{
    static partial class Extension
    {
        public static int ReplayedWordsCount(this string str,string word)
        {
            var parts = str.ToLowerInvariant().Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            word = word.ToLowerInvariant();

            int count = 0;
            foreach (var item in parts)
            {
                string clean = new string(item.Where(char.IsLetterOrDigit).ToArray());
                if (clean == word)
                    count++;
            }

            return count;
        }
    }
}
