using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment51
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, string phoneNumber)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
        }


        public virtual void DisplayStudent()
        {
            //Temp - just ouput to console
            Console.WriteLine("Id: {0}, Name: {1}, Phone {2}: ", Id, Name, PhoneNumber);
        }

    }
}
