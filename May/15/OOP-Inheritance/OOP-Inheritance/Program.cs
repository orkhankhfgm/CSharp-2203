using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass - Car
            //Ata - Ogul
            Car car = new Car();
            car.Id = 1;
            car.Model = "Mercedes";
            car.RegDate = DateTime.Now;

            //car.ToString();
            //car.Color;


            //BaseClass - Person - Student/Teacher/Employee
            //Baba - Ata - Ogul
            Student student = new Student();
            student.Id = 1000;
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Age = 27;
            student.ClassName = "11A";
            student.Degree = "Some Degree";
            student.RegDate = DateTime.Now;


            Teacher teacher = new Teacher();
            teacher.Id = 2000;
            teacher.Name = "Elsad";
            teacher.Surname = "Filankesov";
            teacher.Age = 55;
            teacher.IsProfessor = true;
            teacher.Branch = "Some Branch";
            teacher.RegDate = DateTime.Now;


            Employee employee = new Employee();
            employee.Id = 3000;
            employee.Name = "Filankes";
            employee.Surname = "Filankesov";
            employee.Age = 45;
            employee.Salary = 100;
            employee.JobTitle = "Software Developer";
            employee.RegDate = DateTime.Now;
        }
    }
}
