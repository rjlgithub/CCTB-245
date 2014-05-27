using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment51
{
    public class EveningStudent : Student
    {
        public string RoomNumber { get; set; }
        public string CourseName { get; set; }

        public EveningStudent(string roomNumber, string courseName)
        {
            RoomNumber = roomNumber;
            CourseName = courseName;
        }

        public override void DisplayStudent()
        {
            Console.WriteLine("Id: {0}, Name: {1}, Phone: {2}, Room Number: {3}, Course Name: {4}", Id, Name, PhoneNumber, RoomNumber, CourseName);
        }

    }
}
