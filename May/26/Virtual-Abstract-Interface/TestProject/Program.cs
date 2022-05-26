using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "";
            customer.Surname = "";
            customer.Patronymc = "";
            customer.DateOfBirth = new DateTime();
            customer.SomeProp = "";
            customer.CustomerNumber = "A123456";

            customer.Add();




            Student student = new Student();
            student.Id = 1;
            student.Name = "";
            student.Surname = "";
            student.Patronymc = "";
            student.DateOfBirth = new DateTime();
            student.ClassName = "11B";

            student.Add();
        }
    }
}
