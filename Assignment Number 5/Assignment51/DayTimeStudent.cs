using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment51
{
    public class DayTimeStudent : Student
    {
        public string Section { get; set; }
        public string Locker { get; set; }

        public DayTimeStudent(string section, string locker)
        {
            Section = section;
            Locker = locker;
        }

        public override void DisplayStudent()
        {
            base.DisplayStudent();
            Console.WriteLine("Section: {0}, Locker Number: {1}", Section, Locker);
        }

    }
}
