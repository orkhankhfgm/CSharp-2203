using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowDate(DateTime.Now.Day, DateTime.Now.Month);
            ShowDate(DateTime.Now.Day, DateTime.Now.Month, 2023);

            int num1 = 0; //stack'da yarandi
            SetRef(ref num1);

            //int num2 = 0; //(7.0-dan once bele yazilmali idi)
            int num2;
            SetOut(out num2);

            Addition(1, 1, 1, 1, 5,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5 ,5, 5, 2);
            Addition(1, 1, 1, 1, 5, 6, 10, 50);
            Addition(1, 2, 2, 5, 6 , 8);


            //Method overloading
            Toplama(5, 10);
            Toplama(2.4M, 5.5M);
            Toplama("2", 5);

            //Use method as parameter
            //uzun versiya
            decimal s = Subtraction(15.5M, 2.5M);
            ShowValue(s);

            //qisa versiya
            ShowValue(Subtraction(15.5M, 2.5M));



            //Local functions
            AdditionWithLocalFunc(20, 15);
            SecondAdditionWithLocalFunc(20, 15, 30, 50);
            ThirdAdditionWithLocalFunc(10, 20, 30, 40);
        }

        public static void ShowDate(int day, int month, int year = 2022)
        {
            Console.WriteLine("Tarix: {0}.{1}.{2}", day, month, year);
        }

        static void SetRef(ref int intValue)
        {
            intValue = 10;
        }

        static void SetOut(out int intValue)
        {
            intValue = 15;
        }

        static void Addition(int a, params int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("Toplam: " + total);

            Console.WriteLine("Toplam: " + numbers.Sum());
        }
        //(yanlis: (params int[] numbers, int a))
        //(dogru: (int a, params int[] numbers))



        #region Method overloading
        static void Toplama(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine(total);
        }

        static void Toplama(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            Console.WriteLine(total);
        }

        static void Toplama(string num1, int num2)
        {
            decimal total = decimal.Parse(num1) + num2;
            Console.WriteLine(total);
        }
        #endregion



        #region Use method as parametr
        static void ShowValue(decimal obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static decimal Subtraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        #endregion


        #region Local functions
        static void AdditionWithLocalFunc(int num1, int num2)
        {
            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }
            int result = Addition(num1, num2);
            Console.WriteLine(result);
        }
        
        static void SecondAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int Addition(int num1Local, int num2Local)
            {
                int SecondAddition(int num3Local, int num4Local)
                {
                    return num3Local + num4Local;
                }

                int result = SecondAddition(num3, num4);
                return result + num1Local + num2Local;
            }

            int total = Addition(num1, num2);

            Console.WriteLine(total);
        }

        //(seliqeli version)
        static void ThirdAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int total = 0;

            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int SecondAddition(int num3Local, int num4Local)
            {
                return num3Local + num4Local;
            }

            total += Addition(num1, num2);
            total += SecondAddition(num3, num4);

            Console.WriteLine(total);
        }
        #endregion
    }
}
