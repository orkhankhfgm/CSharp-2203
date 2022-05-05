using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Orkhan";
            customer.Surname = "Farajov";
            customer.Email = "orkhan@gmail.com";
            var email = customer.Email;

            Student student = new Student();
            student.DocumentSerial = "AZ";
            student.DocumentNumber = "12345678";

            var a = student.DocumentSerial;
            var b = student.DocumentNumber;
        }
    }
}
