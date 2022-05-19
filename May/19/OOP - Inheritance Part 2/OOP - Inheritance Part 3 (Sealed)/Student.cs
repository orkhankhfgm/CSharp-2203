using System;

namespace OOP___Inheritance_Part_3__Sealed_
{
    public sealed class Student : Person
    {
        public string Degree { get; set; }
        public string ClassName { get; set; }
        public decimal Attendance { get; set; } //davamiyyet 0-100

        public Student()
        {
            Console.WriteLine("CTOR: Student class");
            MyProtectedMethod();
        }
    }
}
