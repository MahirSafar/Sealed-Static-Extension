namespace Sealed_Static_Extension.Models
{
    class ProgrammingStudent : Student
    {
        public ProgrammingStudent(string fullname, string groupNo, byte age) : base(fullname, groupNo, age) { }

        public sealed override void DoHomeWork()
        {
            Console.WriteLine("Programming");
        }
    }
}
