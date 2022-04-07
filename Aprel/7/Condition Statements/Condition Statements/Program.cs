using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            /*
            if(sert){ //eger
                if serti odendiyi halda isleyecek kodlar
            }else{ //deyilse
                if serti odenmeyib else'e girdikde isleyecek kodlar
            }
            */


            int age = Convert.ToInt32(Console.ReadLine());

            //(iki ayri if ile)
            if (age <= 18)
            {
                Console.WriteLine("Yeniyetme");
            }

            if (age > 18)
            {
                Console.WriteLine("Yetiskin");
            }

            //(if-else ile)
            if (age <= 18)
            {
                Console.WriteLine("Yeniyetme");
                Console.WriteLine("Orkhan");
            }
            else
            {
                Console.WriteLine("Yetiskin");
            }

            //(blok acmadan if yazmagin qaydasi)
            if (age <= 18)
                Console.WriteLine("Yeniyetme");
            else
                Console.WriteLine("Yetiskin");

            //----------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Adinizi daxil edin: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "orkhan")
                Console.WriteLine("name'in deyeri orkhan'dir");
            else
                Console.WriteLine("name'in deyeri orkhan deyil");


            bool result = name.ToLower() == "orkhan";

            if (result) //(result bool tipinde oldugu ucun burada true ve ya false olmasina baxacaq)
            {
                Console.WriteLine("Salam");
                Console.WriteLine("name'in deyeri orkhan'dir");
                Console.WriteLine("Sagol");
            }
            else
            {
                Console.WriteLine("Salam");
                Console.WriteLine("name'in deyeri orkhan deyil");
                Console.WriteLine("Sagol");
            }

            //----------------------------------------------------------------------------------------------------------------------------

            int a = 10;
            int b = 20;

            if (a > 5 && b < 25 && 5 == 5)
                Console.WriteLine("a deyeri 5'den boyuk, b deyeri 25'den kicikdir");

            if (a is Int32)
                Console.WriteLine("a deyiseninin tipi int'dir");
            else
                Console.WriteLine("a deyiseninin tipi int deyil");


            //(if else if)
            string country = "Azerbaycan55";

            if (country == "Turkiye")
                Console.WriteLine("Turkiyenin paytaxti Ankara'dir");
            else if (country == "Almaniya")
                Console.WriteLine("Almaniyanin paytaxti Berlin'dir");
            else if (country == "Italiya")
                Console.WriteLine("Italiyanin paytaxti Roma'dir");
            else if (country == "Azerbaycan")
                Console.WriteLine("Azerbaycanin paytaxti Baki'dir");
            else if (country == "Fransa")
                Console.WriteLine("Fransanin paytaxti Paris'dir");
            else if (country == "Hollandiya")
                Console.WriteLine("Hollandiyanin paytaxti Amsterdam'dir");
            else if (country == "Polsa")
                Console.WriteLine("Polsanin paytaxti Warsaw'dir");
            else
                Console.WriteLine("Hec bir sert odenmedi");


            //Task in lesson 1:
            /*
             0-dan kicik 100-den boyukdurse "Duzgun bal daxil edilmeyib"

            20-den kicik olsa "Imtahandan kesildiniz"
            20-den boyuk ve ya beraber, 40-dan kicik olsarsa "Tebrikler, Siz imtahandan kecdiniz" yazsin ve altinda da "Netice: Qenaetbexs"
            40-dan boyuk ve ya beraber, 60-dan kicik olsarsa "Tebrikler, Siz imtahandan kecdiniz" yazsin ve altinda da "Netice: Kafi"
            60-dan boyuk ve ya beraber, 80-dan kicik olsarsa "Tebrikler, Siz imtahandan kecdiniz" yazsin ve altinda da "Netice: yaxsi"
            80-a beraber ve ya boyuk olsarsa "Tebrikler, Siz imtahandan kecdiniz" yazsin ve altinda da "Netice: ela"
             */

            string examPointStr = Console.ReadLine();
            int examPoint = 0;

            bool parseInt = int.TryParse(examPointStr, out examPoint);

            if (!parseInt)
                Console.WriteLine("Xahis olunur bir reqem daxil edin!");
            else if (examPoint < 0 || examPoint > 100)
                Console.WriteLine("Duzgun bal daxil edilmeyib!");
            else if (examPoint < 20)
                Console.WriteLine("Imtahandan kesildiniz!");
            else
            {
                Console.WriteLine("Tebrikler, Siz imtahandan kecdiniz!");

                if (examPoint >= 20 && examPoint < 40)
                {
                    Console.WriteLine("Netice: Qenaetbexs");
                }
                else if (examPoint >= 40 && examPoint < 60)
                {
                    Console.WriteLine("Netice: Kafi");
                }
                else if (examPoint >= 60 && examPoint < 80)
                {
                    Console.WriteLine("Netice: yaxsi");
                }
                else if (examPoint >= 80)
                {
                    Console.WriteLine("Netice: ela");
                }
            }
            #endregion




            #region Nested if else
            var firstname = "Orkhan";
            var surname = "Farajov";
            var dateOfBirth = new DateTime(1995, 12, 24);
            var job = "Developer";

            if (firstname == "Orkhan" && surname == "Farajov")
            {
                if (dateOfBirth.Year == 1995 && dateOfBirth.Month == 12 && dateOfBirth.Day == 24)
                {
                    if (job == "Developer")
                    {
                        Console.WriteLine("Xos geldin " + firstname);
                    }
                    else
                    {
                        Console.WriteLine("Job yanlis daxil edilib!");
                    }
                }
                else
                {
                    Console.WriteLine("Dogum tarixi yanlisdir!");
                }
            }
            else
            {
                Console.WriteLine("Ad ve ya soyad yanlisdir!");
            }
            #endregion





            #region Switch-Case
            string langOrFamework = "C#";

            switch (langOrFamework)
            {
                case "ASP.NET":
                    Console.WriteLine("Microsoft");
                    break;
                case "F#":
                    Console.WriteLine("Microsoft");
                    break;
                case "C#":
                    Console.WriteLine("Microsoft");
                    break;
                case "Java":
                    Console.WriteLine("Oracle");
                    break;
                default:
                    Console.WriteLine("Hec bir case uygun gelmedi!");
                    break;
            }

            if (langOrFamework == "ASP.NET")
                Console.WriteLine("Microsoft");
            else if (langOrFamework == "F#")
                Console.WriteLine("Microsoft");
            else if (langOrFamework == "C#")
                Console.WriteLine("Microsoft");
            else if (langOrFamework == "Java")
                Console.WriteLine("Oracle");
            else
                Console.WriteLine("Hec bir case uygun gelmedi!");



            //Task in Lesson 3
            int month = 5;
            const int feb = 2;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case feb:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Iyun");
                    break;
                case 7:
                    Console.WriteLine("Iyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr");
                    break;
                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
                    //default yazilmasa da olar
            }



            string job1 = "Mobile developer";

            switch (job1)
            {
                case "Developer":
                    Console.WriteLine("Proqramci proqram teminati hazirlayir.");
                    break;

                case "Design":
                    Console.WriteLine("Dizayner muxtelif dizaynlar hazirlayir");
                    break;

                case "Web Designer":
                    Console.WriteLine("Salam web dizayner!");
                    goto case "Design";

                case "Mobile developer":
                    Console.WriteLine("Salam mobile developer");
                    goto case "Developer";
            }

            //Multiple cases
            string code = "AA";

            switch (code)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin");
                    break;

                case "DD":
                case "FF":
                    Console.WriteLine("Editor");
                    break;
                
                case "GG":
                case "HH":
                    Console.WriteLine("Registered User");
                    break;
                
                case "II":
                case "JJ":
                case "KK":
                    Console.WriteLine("Standart User");
                    break;
            }
            #endregion
        }
    }
}
