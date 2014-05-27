using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment51
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayStudentA();
            DisplayStudentB();
        }

        static void DisplayStudentA()
        {
            DayTimeStudent studentA = new DayTimeStudent("S18", "HP2298");
            studentA.Id = 1;
            studentA.Name = "Bob Smith";
            studentA.PhoneNumber = "(780) 421-1234";

            studentA.DisplayStudent();

        }

        static void DisplayStudentB()
        {
            EveningStudent studentB = new EveningStudent("WB201", "C#");
            studentB.Id = 2;
            studentB.Name = "Jane Doe";
            studentB.PhoneNumber = "(780) 773-7763";

            studentB.DisplayStudent();

        }

    }
}
