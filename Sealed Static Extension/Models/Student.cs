using System.Text.RegularExpressions;
using Sealed_Static_Extension.Helper;

namespace Sealed_Static_Extension.Models
{
    class Student
    {
        private string _fullname;
        public string Fullname 
        {
            get => _fullname;
            set
            {
                if (!value.IsValidFullName())
                    Console.WriteLine("Please enter correct fullname");
                else
                    _fullname = value;
            }
        }
        private string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (!value.IsValidGroupNo())
                    Console.WriteLine("Please enter correct group number");
                else
                    _groupNo = value;
            }
        }
        public byte Age { get; set; }
        public Student(string fullname, string groupNo, byte age)
        {
            Fullname = fullname;
            _groupNo = groupNo;
            Age = age;
        }
    }

}
