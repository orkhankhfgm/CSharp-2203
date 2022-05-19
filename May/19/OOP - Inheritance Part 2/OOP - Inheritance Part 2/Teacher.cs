using System;

namespace OOP___Inheritance_Part_2
{
    public class Teacher : Person
    {
        public string Branch { get; set; }
        public string Level { get; set; }
        public string IsProfessor { get; set; }

        public Teacher()
        {
            Console.WriteLine("Constructor of Teacher class");
        }
    }
}
