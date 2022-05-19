using System;

namespace OOP___Inheritance_Part_2
{
    public class Student : Person
    {
        public string Degree { get; set; }
        public string ClassName { get; set; }
        public decimal Attendance { get; set; } //Davamiyyet: 100/0

        public Student()
        {
            Console.WriteLine("Constructor of Student class");
        }
    }
}
