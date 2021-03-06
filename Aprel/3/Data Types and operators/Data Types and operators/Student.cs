using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_operators
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Student(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public static implicit operator string(Student s) => s.Name + " " + s.Surname + " " + s.Age;

        public override string ToString() => Name + " " + Surname + " " + Age;
    }
}
