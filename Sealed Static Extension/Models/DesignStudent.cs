using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Static_Extension.Models
{
    class DesignStudent : Student
    {
        public DesignStudent(string fullname, string groupNo, byte age) : base(fullname, groupNo, age){}

        public sealed  override void DoHomeWork()
        {
            Console.WriteLine("Designer");
        }
    }
}
