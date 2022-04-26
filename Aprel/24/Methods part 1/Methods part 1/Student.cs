using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_part_1
{
    /*
     Method necə yazılır?
     [access modifiers] [return type] [method name] (parameters)
     {
        method'un body hissesi
     }

     Access modifiers:
     1. Public
     2. Private
     3. Protected
     4. Internal
     5. Internal protected
     */
    public class Student
    {
        public void HelloStudent()
        {
            Console.WriteLine("Salam telebe!");
        }

        private void ShowStudentInfo(string name, string surname)
        {
            Console.WriteLine("Telebe melumatlari: {0} {1}", name, surname);
        }

        public void ShowHasanInfo()
        {
            ShowStudentInfo("Hesen", "Haciyev");
        }

        public void ShowOrkhanInfo()
        {
            ShowStudentInfo("Orkhan", "Farajov");
        }
    }

    
}
