using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Syntax of programming language

            #endregion

            #region What is Visual Studio
            //ID
            //IDE
            #endregion

            #region First C# Code
            // 1. (System - namespace adı)
            // 2. (Console - System namespace'nin içində bir class adı)
            // 3. (Write - Console class'ının içində bir method)

            //Read: method'u ilk simvolun key deyerini goturur //50
            //ReadKey: ilk basilan simvolun herfini ve kodunu qaytarir
            //ReadLine: butun text'i metn olaraq qaytarir
            Console.WriteLine("Klaviaturada bir klavise basin:");
            var read = Console.Read();
            Console.WriteLine("Basilan klavis deyeri: " + read.ToString());

            Console.WriteLine("Klaviaturada bir klavise basin:");
            var readKey = Console.ReadKey();
            Console.WriteLine("Basilan klavis deyeri: " + readKey.KeyChar.ToString());
            Console.WriteLine("Basilan klavis reqem qarsiligi: " + readKey.Key.ToString());
            
            
            Console.WriteLine("Bir text daxil edin:");
            var readLine = Console.ReadLine();
            Console.WriteLine("Daxil edilen text: " + readLine);
            #endregion

            #region Breakpoint atmaq
            Console.WriteLine("Top 1");
            Console.WriteLine("Top 2");
            Console.WriteLine("Top 3");
            Console.WriteLine("Top 4");
            Console.WriteLine("Top 5");
            Console.WriteLine("Top 6");
            Console.WriteLine("Top 7");
            Console.WriteLine("Top 8");
            Console.WriteLine("Top 9");
            Console.WriteLine("Top 10");

            //Breakpoint atıb (qırmızını soldakı boşluğa qoyandan sonra)
            //Bir-bir davam etmək üçün F10 knopkasına basırsınız.
            //Birbaşa növbəti breakpoint'ə və ya yoxdursa proqramın sonuna getmək istəyirsinizsə F5-ə basırsınız.
            #endregion

            #region lesson task
            // 4 dene deyiseniniz olsun:
            //red'in deyeri qirmizi olsun
            //car'in deyeri avtomobil
            //expensive'in deyeri bahali
            //phone'un deyeri telefon

            var red = "Qirmizi";
            var car = "avtomobil";
            var expensive = "Bahali";
            var phone = "Telefon";

            Console.WriteLine(red + " " + car);
            Console.WriteLine(expensive + " " + phone);

            #endregion

            #region Comments and regions
            //this comment is a single-line comment

            /*
             * This
             * is
             * a
             * multi-line
             * comment
             */
            #region Registration
            //Here is registration section
            #endregion

            #region Logion
            //Here is login section
            #endregion

            #region Profile section
            //Here is profile section
            #endregion

            #endregion

            #region Variables
            //Deyisen yaratmaq: type nameOfVariable = value
            var red1 = "Qirmizi";

            string person = "Orkhan Farajov";
            Console.WriteLine(person);

            string anotherPerson;
            anotherPerson = "Cabir Isayev";
            Console.WriteLine(anotherPerson);

            string name = "Orkhan";
            Console.WriteLine(name);

            name = "Fuad";
            Console.WriteLine(name);
            #endregion

            #region Naming Convention
            /*
             writeLine
             _nameSurname;
             nameSurname;
             anotherPerson;
             nameSurname1;
             fatherName;
             anotherFatherName;
             */
            #endregion
        }
    }
}
