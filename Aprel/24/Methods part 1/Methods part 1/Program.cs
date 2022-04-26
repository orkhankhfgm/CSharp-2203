using System;

namespace Methods_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();

            Student student = new Student();
            //student.ShowStudentInfo("Samir", "Ferecov"); //(private oldugu ucun burada elcatan deyil)


            student.ShowHasanInfo();
            student.ShowOrkhanInfo();
        }

        static void SayHello()
        {
            Console.WriteLine("Salam necesen ne var ne yox?");
        }
    }
}
