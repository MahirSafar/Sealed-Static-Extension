using System.Text.RegularExpressions;

namespace Sealed_Static_Extension.Helper
{
    static class StudentExtension
    {
        public static bool IsValidGroupNo(this string groupNo) => Regex.IsMatch(groupNo, @"^[A-Z]{1}\d{3}$");
        public static bool IsValidFullName(this string fullname) => Regex.IsMatch(fullname, @"^[A-Z][a-z]+ [A-Z][a-z]+$");
    }
}
