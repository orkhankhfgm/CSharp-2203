using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesInRam
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value Types
            //Value type dəyişənlər, RAM'ın stack sahəsində saxlanılır.

            //Photo -> Stack Area.png
            //Nümunə 1:
            int a;
            a = 5200;
            a = 2147480466;

            //Nümunə 2:
            int b;
            b = 5;
            b = 17;
            byte c = 5;

            //Nümunə 3:
            int i = 2147483647; //4 byte yer tutur ve 32 bit'dir
            double x = 500.1; //8 byte'dir ve 64 bit yer tutur
            x = i;
            x = 150;
            #endregion




            #region Reference Types
            //Reference type dəyişənlər, RAM'ın Heap sahəsində saxlanılır (Stack sahə də istifadə olunmaqla).
            //Photo -> Heap Area.png
            Student student;
            student = new Student();

            student.Name = "Orkhan";
            student.Age = 27;
            student.Point = 78.5;
            
            
            Student otherStudent = new Student();
            otherStudent.Name = "Babek";
            otherStudent.Age = 20;
            otherStudent.Point = 71.6d;


            student = otherStudent;

            otherStudent.Name = "Fuad";
            #endregion




            #region String helper methods
            string employee = "Orkhan Farajov";
            string upperCase = employee.ToUpper();
            string lowerCase = employee.ToLower();
            string partOfString = employee.Substring(2, 4);
            #endregion
        }
    }
}
