using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Recursive methods
            int a = GenerateNum(1);

            int faktorial10 = Faktorial(10);
            int faktorial0 = Faktorial(0);
            int faktorial5 = Faktorial(5);
            #endregion

            #region What is Static?
            Student student;
            //student.Name = "a";
            Student.Test1();

            student = new Student();
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Email = "orkhankhf@gmail.com";
            student.Test();
            #endregion



            #region Where and why to use static?
            //1 - Helper class'lar
            //2 - Static field'lar
            //3
            //4
            //Orkhan Farajov
            //M. Mehemmedsalamov

            //Task no 1
            var normalName = StringHelper.CheckFullname("Orkhan", "Farajov");
            var longFullname = StringHelper.CheckFullname("OrkhanOrkhanOrkhan", "Farajov");
            var longFullname2 = StringHelper.CheckFullname("Orkhan Middlename", "Farajov");
            var longFullname3 = StringHelper.CheckFullname("Orkhan Ibn Khayyam", "Farajov");

            //Task no 2
            Staff st = new Staff();
            st.Name = "Orkhan";
            st.Surname = "Farajov";
            st.Email = "orkhan.farajov"; //orxan.farajov@oxu.az
            st.Gender = 1;

            EmailHelper.SendWelcomeMail(st.Email);
            EmailHelper.SendPasswordChangeMail(st.Email);
            #endregion
        }

        #region Recursive methods
        static int Faktorial(int num)
        {
            if (num == 0)
                return 1;

            return num * Faktorial(num - 1);
        }

        static int GenerateNum(int num)
        {
            if (num == 100)
                return num;

            return num + GenerateNum(num + 1);
        }
        #endregion
    }
}
