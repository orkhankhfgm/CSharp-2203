using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For loop

            //Numune 1
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Salam");
            }

            Console.Clear();

            //Numune 2
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //Numune 3
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //Numune 4
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //Numune 5
            for (int i = 0; i < 100; i += 10)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //Numune 6
            //infinity loop
            //for ( ; ; )
            //{
            //    Console.WriteLine("salam");
            //}

            //Numune 7
            //infinity loop
            //int counter = 0;
            //for (; ; counter++)
            //{

            //}

            //Numune 8
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Oneline for loop: " + i);

            Console.Clear();

            //Numune 9 (break)
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine("Counter: " + i);
            }

            Console.Clear();

            //Numune 10 (nested loop)
            for (int i = 0; i < 10; i++)
            {
                for (int x = 10; x < 20; x++)
                {
                    Console.WriteLine("i: " + i + " --- x: " + x);
                }
            }

            Console.Clear();

            //Numune 11
            for (int a1 = 0; a1 < 10; a1++)
            {
                for (int b1 = 0; b1 < 10; b1++)
                {
                    for (int c1 = 0; c1 < 10; c1++)
                    {
                        for (int d1 = 0; d1 < 10; d1++)
                        {
                            Console.WriteLine("a: " + a1 + " --- b: " + b1 + "c: " + c1 + " --- d: " + d1);
                        }
                    }
                }
            }

            Console.Clear();

            //Numune 12 (yolka agaci)
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Task 1: 1-den 100-e qeder reqemlerin toplamini ekrana yazdirin;
            //Task 2: sadece cut reqemlerin toplamini ekrana yazdirin;

            //Solution 1
            int result = 0;
            for (int i = 1; i <= 100; i++)
                result += i;

            Console.WriteLine("1-den 100-e qeder reqemlerin toplami: " + result);

            result = 0;

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)
                    result += i;
            }
            Console.WriteLine("1-den 100-e qeder cut reqemlerin toplami: " + result);
            #endregion



            #region While loop
            //Numune 1:
            var continueLoop = true;

            while (continueLoop)
            {
                int sec = DateTime.Now.Second;

                if (sec > 30 && sec < 45)
                {
                    Console.WriteLine("End");
                    break;
                }
                else //(yazilmasa da olar)
                    Console.WriteLine(sec);
            }

            //Numune 2:
            int countWhile = 1;

            while (countWhile <= 100)
            {
                Console.WriteLine("Counter: " + countWhile);
                countWhile++;
            }

            while (5 > 10)
            {
                Console.WriteLine("Test");
            }

            //1 - ci variant
            bool stopLoop = false;
            while (!stopLoop)
            {
                string text = Console.ReadLine();
                if (text != "exit")
                    Console.WriteLine(text);
                else
                    stopLoop = true;

                var nm = "Orkhan";
            }

            //2-ci variant
            while (true)
            {
                string text = Console.ReadLine();
                if (text != "exit")
                    Console.WriteLine(text);
                else
                    break;

                var nm = "Orkhan";
            }
            #endregion




            #region Do-While
            bool startChat = false;

            while (startChat)
            {
                if (startChat == false) //!startChat
                {
                    Console.WriteLine("Sohbet basladilsin? He/Yox");
                    string answer = Console.ReadLine();

                    if (answer == "he")
                        startChat = true;
                    else if (answer == "yox")
                        break;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sehv cavab daxil etdiniz!");
                        Console.WriteLine("Sohbet basladilsin? He/Yox");
                    }
                }
                else
                {
                    Console.WriteLine("Mesajinizi daxil edin: ");
                    string text = Console.ReadLine();

                    if (text == "exit")
                        break;

                    Console.WriteLine(text);
                }
            }




            do
            {
                if (startChat == false)
                {
                    Console.WriteLine("Sohbet basladilsin? He/Yox");
                    string answer = Console.ReadLine();

                    if (answer == "he")
                        startChat = true;
                    else if (answer == "yox")
                        break;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sehv cavab daxil etdiniz!");
                        Console.WriteLine("Sohbet basladilsin? He/Yox");
                    }
                }
                else
                {
                    Console.WriteLine("Mesajinizi daxil edin: ");
                    string text = Console.ReadLine();

                    if (text == "exit")
                        break;

                    Console.WriteLine(text);
                }
            } while (startChat);
            #endregion




            #region Foreach
            string[] citiesArray = new string[5];

            citiesArray[0] = "Baki";
            citiesArray[1] = "Gence";
            citiesArray[2] = "Sumqayit";
            citiesArray[3] = "Zerdab";
            citiesArray[4] = "Naxcivan 085";

            foreach (var item in citiesArray)
            {
                Console.WriteLine("Seher: " + item);
            }

            for (int a1 = 0; a1 < citiesArray.Length; a1++)
            {
                Console.WriteLine("Seher: " + citiesArray[a1]);
            }
            #endregion



            #region Variable declerations inside/outside loop bodies
            string globalVariableName = "Orkhan";

            for (int i = 0; i < 5; i++)
            {
                globalVariableName = "Name can change here";
            }


            for (int i = 0; i < 5; i++)
            {
                string localVariableName = "Fuad";

                for (int g = 0; g < 10; g++)
                {
                    localVariableName = "Test";
                }
            }

            //localVariableName = "local variable can't be changed here";
            Random rand = new Random();

            int a = rand.Next(1, 100);
            int b = rand.Next(1, 5000);

            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.WriteLine();
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");
            Console.Write("1*1=2\t");

            Console.Clear();



            Console.WriteLine("Bir eded yazin: ");
            string c = Console.ReadLine();
            Console.WriteLine("---------------------");
            int cntr = int.Parse(c);

            while (cntr != 1)
            {
                Console.WriteLine(cntr);
                cntr = cntr - 1;
            }


            int z = Convert.ToInt32(null);
            int z1 = int.Parse(null);
            #endregion
        }
    }
}
