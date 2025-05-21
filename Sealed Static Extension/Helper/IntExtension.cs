namespace Sealed_Static_Extension.Helper
{
    static partial class Extension
    {
        public static bool IsOdd(this int num) => num % 2 != 0;
        public static bool IsEven(this int num) => num % 2 == 0;
        public static bool IsPalindrome(this int number) 
        {
            if (number < 0) return false;

            string str = number.ToString();
            string reversed = new string(str.Reverse().ToArray());

            return str == reversed;
        }
    }
}