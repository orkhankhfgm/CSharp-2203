using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Loops homework
            ////Solution 1:
            //Console.WriteLine("Toplamaq istediyiniz reqemleri daxil edin: ");
            //Console.WriteLine("Qeyd: Neticeni gormek ucun menfi eded daxil edin.");

            //decimal sum = 0;

            //while (true)
            //{
            //    string uInput = Console.ReadLine();
            //    decimal value = decimal.Parse(uInput);

            //    if (value < 0)
            //        break;
            //    else
            //        sum = sum + value;
            //        //sum += value;
            //}

            //Console.WriteLine("Toplam: {0}", sum);

            ////Solution 2:
            //int result = 0;
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int y = 1; y <= 9; y++)
            //    {
            //        result = i * y;
            //        Console.Write("{0}*{1}={2}\t", i, y, result);
            //    }
            //    Console.WriteLine();
            //}


            ////Solution 3:
            //int estimate, generatedNum, counter = 0;

            //Console.WriteLine("Texmin oyunu ucun en yuksek reqemi daxil edin: ");
            //int maxNum = int.Parse(Console.ReadLine());
            //Random rand = new Random();
            //generatedNum = rand.Next(1, maxNum);

            //do
            //{
            //    counter++;
            //    Console.WriteLine("{0}. Cehdiniz! Zehmet olmasa reqemi texmin edin: ", counter);
            //    estimate = int.Parse(Console.ReadLine());
            //} while (estimate != generatedNum);

            //Console.WriteLine("{0}. Cehdinizde duzgun reqemi tapdiniz!", counter);
            #endregion

            //Nümunə 1:
            int[] numArray = new int[6]; //[]

            numArray[0] = 100; //assign value

            int getVal = numArray[0]; //getting value of an array element


            //Nümunə 2:
            int[] secondArray; //(stack'da yarandı hələ)
            secondArray = new int[6]; //(heap'da yaranıb, ref adresi stack'da set edildi)

            //Nümunə 3:
            int[] thirdArray = new int[7]
            {
                150,
                245,
                377,
                99,
                0,
                655,
                15
            };
            
            thirdArray[2] = 50;
            
            int age = thirdArray[6];


            //Nümunə 4:
            int[] fourthNumArray = new int[] {
                10, 20, 30, 40, 50, 60, 70
            };

            //fourthNumArray[7] = 10; //(error)


            #region Use Arrays with diffrent data types
            //string
            string[] names = new string[5];
            names[0] = "Orkhan";
            names[1] = "John";
            names[2] = "Bill";
            names[3] = "Mark";
            names[4] = "Jessica";

            var orkhan = names[0];
            var john = names[1];
            var jessica = names[4];


            //char
            char[] alphabet = new char[]
            {
                'A',
                'B',
                'C',
                'D'
            };

            //object
            object[] objArr = new object[7];
            objArr[0] = 5;
            objArr[1] = "string type";
            objArr[2] = true;
            objArr[3] = 2.5f;
            objArr[4] = DateTime.Now;
            objArr[5] = 999999999999999999;
            objArr[6] = '/';
            
            object[] objArr2 = new object[] {
                5,
                true,
                ""
            };


            DateTime date = new DateTime(1995, 12, 12);
            objArr[6] = date;

            int intType = (int)objArr[0];
            string stringType = (string)objArr[1];
            long longType = (long)objArr[5];
            #endregion





            #region Loop and Arrays
            //Console.WriteLine("Sinifde nece telebe var?");
            //short studentCount = Convert.ToInt16(Console.ReadLine());

            //string[] students = new string[studentCount];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(i + ". Telebenin adini daxil edin: ");
            //    students[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Multidimensional Arrays
            //5x3 (Matris Array)
            int[,] _5x2 =
            {
                { 1, 2, 3},
                { 3, 4, 3},
                { 5, 6, 3},
                { 7, 8, 3},
                { 9, 10, 3}
            };
            _5x2[0, 0] = 10;
            _5x2[2, 1] = 10;

            //(Jagged Array)
            int[][] jaggedArr = new int[][]
            {
                new int[2] { 100, 200}, //Array
                new int[6] { 101, 102, 103, 104, 105, 106}, //Array
                new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, //Array
                new int[] { 1000, 2000, 3000, 4000 } //Array
            };
            jaggedArr[0][0] = 10;

            var a = jaggedArr[2][3];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int x = 0; x < jaggedArr[i].Length; x++)
                {
                    Console.WriteLine(i + "." + x + ": " + jaggedArr[i][x]);
                }
            }
            #endregion


            #region Array methods
            /*
             Properties:
                IsFixedSize
                IsReadOnly
                Length

             Methods:
                Clone()
                Array.IndexOf()
                CopyTo()
                Sort()
                Reverse()
                Clear()
             */

            string[] persons = new string[]
            {
                "Orxan Ferecov",
                "Bill Gates",
                "Mark Zuckenberg",
                "Mark Henry"
            };

            bool isFixedSize = persons.IsFixedSize;
            bool isReadOnly = persons.IsReadOnly;
            int length = persons.Length;

            var clonedArray = persons.Clone();

            int orkhansIndex = Array.IndexOf(persons, "Orxan Ferecov");

            string[] copiedPersons = new string[10];
            persons.CopyTo(copiedPersons, 4);

            Array.Sort(persons);

            Array.Reverse(persons);

            Array.Clear(persons, 2, 2);
            #endregion

            string name = "";
            Console.ReadLine();
        }
    }
}
