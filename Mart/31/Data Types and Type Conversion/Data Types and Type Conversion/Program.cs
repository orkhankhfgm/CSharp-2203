using System;
using System.Text;

namespace Data_Types_and_Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Salam, xoş gəlmisiniz");

            Console.WriteLine("Adınızı daxil edin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadınızı daxil edin: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Doğulduğunuz ölkəni daxil edin: ");
            string country = Console.ReadLine();

            Console.WriteLine("Boyunuzu daxil edin: ");
            string height = Console.ReadLine();

            Console.WriteLine("Çəkinizi daxil edin: ");
            string weight = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Ad: " + name);
            Console.WriteLine("Soyad: " + surname);
            Console.WriteLine("Ölkə: " + country);
            Console.WriteLine("Boy: " + height);
            Console.WriteLine("Çəki: " + weight);


            //Task 1:
            //Xoş gəlmisiniz
            //Adını soruşun (Orxan)
            //Müraciət qaydası (bəy)

            //Orxan bəy, neçə yaşınız var?
            //işlədiyi sahə
            //ən son nə zaman kitab oxumusunuz?
            //sevdiyiniz rəng hansıdır?
            //avtomobil idarə edə bilirsiniz?
            //gündə neçə saat komputer arxasında olursunuz?


            #region Type Conversion
            {
                /*
                    1. Implicit Type Conversion
                    2. Explicit Type Conversion
                    3. User-Defined Type Conversion
                    4. Helper Classes (Convert)
                */

                //Implicit Type Conversion
                //Nümunə 1:
                byte byteVal = byte.MaxValue; //255
                short shortVal = short.MaxValue; //32767
                short takeByteVal = byteVal; //(implicit conversion)
                //byte takeShortVal = shortVal;

                //Nümunə 2:
                int takeShortVal = shortVal;

                //Nümunə 3:
                int takeBtVal = byteVal;

                //Nümunə 4:
                int i = 5000;
                long l = i;

                long l2 = 5000000;
                float f = l2;

                float f2 = 25.5F;
                double d = f2;

                int a = 200;
                //short b = a;

                //Ardicilliq: byte -> short -> int -> long -> float -> double
            }
            #endregion



            #region Signed - Unsigned data types
            {
                // Signed: menfi, 0, musbet
                // Unsigned: 0-dan boyuk

                //Unsigned:
                byte us1 = byte.MinValue;
                ushort us2 = ushort.MaxValue;
                uint us3 = uint.MinValue;
                ulong us4 = ulong.MinValue;

                //Signed:
                short s1 = short.MinValue;
                int s2 = int.MinValue;
                long s3 = long.MinValue;
                sbyte s4 = sbyte.MinValue;

                //unsigned ushort deyer araligi: 0 ile 65535
                //signed short deyer araligi: -32768 ile 32767
                //32767 - (-32768) = 65535
            }
            #endregion



            #region Explicit Type Conversion
            {
                int a = 20000;
                //short b = a;

                double c = 785.02;
                //float d = c;

                short e = 10;
                //ushort f = e;

                float g = 15.5F;
                //long l = g;

                //Nümunələr:
                int a1 = 40000;
                short b1 = (short)a1;

                double c1 = 785.02;
                float d1 = (float)c1;

                short e1 = 10;
                ushort f1 = (ushort)e1;

                long yas = 25;
                char yasChar = (char)yas;
                //double -> float -> long -> int -> char
            }
            #endregion

            #region Checked & Unchecked
            //Casting without Checked keyword
            long longVar = Convert.ToInt64(Console.ReadLine()); //999999999999
            int takeLongVar = (int)longVar;

            short shortVar = Convert.ToInt16(Console.ReadLine()); //30000
            byte takeShortVar = (byte)shortVar;

            //Casting with Checked keyword
            checked
            {
                int money = Convert.ToInt32(Console.ReadLine()); //100.000
                short takeInt = (short)money;

                unchecked
                {
                    byte age = Convert.ToByte(Console.ReadLine()); //200
                    sbyte takeByte = (sbyte)age;
                }
            }
            #endregion


            #region Helper Class Conversions
            string numberString = "50";
            int number;

            //Implicit
            //number = numberString;

            //Explicit
            //number = (int)numberString;

            number = Convert.ToInt32(numberString);

            //NOT POSSIBLE
            //bool booleanVariable = 1;
            //bool booleanVariable = (bool)1;
            //int intVariable = (int)"1";
            //int intVariable = (int)true;

            //Possible
            bool booleanVariable;
            booleanVariable = Convert.ToBoolean(1); // true
            booleanVariable = Convert.ToBoolean("true"); // true 
            //booleanVariable = Convert.ToBoolean("0");
            booleanVariable = Convert.ToBoolean(null); // false

            int integerVariable;
            integerVariable = Convert.ToInt32("10"); //10
            integerVariable = Convert.ToInt32(null); //0
            integerVariable = Convert.ToInt32(true); //1
            integerVariable = Convert.ToInt32(false); //0

            string numString = "45";
            //short stringToShort = numString;
            //short stringToShortCast = (short)numString;
            short stringToShortConvert = Convert.ToInt16(numString);

            //int stringToInt = numString;
            //int stringToIntCast = (int)numString;
            int stringToIntConvert = Convert.ToInt32(numString);

            //long stringToLong = numString;
            //long stringToLongCast = (long)numString;
            long stringToLongConvert = Convert.ToInt64(numString);

            int intVariable = 10;
            long longVariable = 9999999;
            bool boolVariable = true;

            string getStringVal = intVariable.ToString();
            getStringVal = longVariable.ToString();
            getStringVal = boolVariable.ToString();

            bool _boolVar = Convert.ToBoolean("false");
            byte _byteVar = Convert.ToByte("10");
            char _charVar = Convert.ToChar("A");
            DateTime _dateTimeVar = Convert.ToDateTime("2020-12-12");
            short _shortVar = Convert.ToInt16("-25000");
            ushort _ushortVar = Convert.ToUInt16("9500");

            uint _uintVariable = Convert.ToUInt32("-1");
            #endregion

            Console.ReadLine();
        }
    }
}
