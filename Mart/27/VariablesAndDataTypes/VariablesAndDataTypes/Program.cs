using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        public static string Country { get; set; } = "Azerbaijan";

        static void Main(string[] args)
        {
            #region What is Data Type
            string oneString = "1";
            int oneInteger = 1;

            Country = "Turkey";

            string aString = "a";
            //int aInteger = "a"; (xəta)

            /*
             Byte hesablama düsturu:
             1 byte = 8 bit

             Int16 tipi 16 bit'dir. 16 bit / 8 bit = 2 byte
             Int32 tipi 32 bit'dir. 32 bit / 8 bit = 4 byte
             Int64 tipi 64 bit'dir. 64 bit / 8 bit = 8 byte
             */

            /*
             Value-Type data tipləri:
             bool
             byte
             char
             decimal
             double
             enum
             float
             int
             long
             sbyte
             short
             struct
             char
             uint
             ulong
             ushort


             Reference-Type data tipləri:
             string
             Arrays
             class
             delegate

             Not: Reference-Type olan data tiplerinin default deyerleri her zaman null olur.
             */
            #endregion

            #region Practice with data types
            {
                //Boolean
                //hecmi: 1 bit
                //deyer araligi true ve ya false
                bool booleanVar = true;
                booleanVar = false;

                bool otherBooleanVar;
                otherBooleanVar = true;
            }

            {
                //String
                //hecmi: her bir xarakter ucun 1 byte
                string name_ = "Orkhan";
                Console.WriteLine(name_);

                string surname = "Farajov";
                Console.WriteLine(surname);

                string nameSurname = "Teymur Jafarov";

                string upperNameSurname = nameSurname.ToUpper();

                string lowerNameSurname = nameSurname.ToLower();

                string subString = nameSurname.Substring(1, 5);

                bool startsWith = nameSurname.StartsWith("t");

                bool endsWith = nameSurname.EndsWith("v");

                int length = nameSurname.Length;

                int indexOf = nameSurname.IndexOf("y");

                bool equals = nameSurname.Equals("teymur jafarov");
                bool equals2 = nameSurname.Equals("Teymur Jafarov");
            }
            
            {
                //Short, Int, Long Types
                //hecmleri:
                    //int16: 2 byte
                    //int32: 4 byte
                    //int64: 8 byte
                //ala bildikleri deyer araliqlari:
                    //int16 ucun: -32768 --- 32767
                    //int32 ucun: -2147483648 --- 2147483647
                    //int64 ucun: -9223372036854775808 --- 9223372036854775807
                
                short shortMinValue = short.MinValue;
                short shortMaxValue = short.MaxValue;
                short shortValue = 18262;
                short shortValueNegative = -1562;

                int intMinValue = int.MinValue;
                int intMaxValue = int.MaxValue;
                int intValue1 = 2458745;
                int intValueNegative = -222666;

                long longMinValue = long.MinValue;
                long longMaxValue = long.MaxValue;
                long longValue = 1515616515615615656;
                long longValueNegative = -1515616515615615615;

                string intToString = intValue1.ToString();

                //1 Task
                int val1 = 10;
                int val2 = 20;
                int sum = val1 + val2;

                //2 Task
                string aze = "Azerbaijan";
                string tur = "Turkey";
                string azeTur = aze + " and " + tur;
            }

            {
                //Char
                //hecmi: 2 byte
                string a = "A";
                string b = "B";
                string c = "C";
                string d = "D";
                string e = "E";
                string f = "F";

                char charA = 'A';
                char charB = 'b';
                char charC = 'C';
                char charD = 'D';
                char charE = 'E';
                char charF = 'F';

                char symbol = '*';
                char whiteSpace = ' ';
                char question = '?';

                char toLower = char.ToLower(charA);
                char toUpper = char.ToUpper(charB);
                bool isLower = char.IsLower(charB);
                bool isUpper = char.IsUpper(charC);

                bool isNumber = char.IsNumber(charF);
                bool isLetter = char.IsLetter(charD);
                bool isDigit = char.IsDigit(charF);
                bool isWhiteSpace = char.IsWhiteSpace(whiteSpace);
            }

            {
                //Byte
                //hecmi: 1 byte
                //deyer araligi: 0-255
                byte byteVariable = 45;
                byte byteMinValue = byte.MinValue;
                byte byteMaxValue = byte.MaxValue;
            }

            {
                //Double
                //hecmi: 8 byte
                //precision: 15-16
                double doubleVar = 10.2;
                double doubleVar2 = 25;
                double doubleVar3 = 45.8d;

                double doubleMinVal = double.MinValue;
                double doubleMaxVal = double.MaxValue;

                double nan = 0.0 / 0.0; //NaN
                double notNan = 5 / 2.5;
                bool resultOfNan = double.IsNaN(nan);
                bool resultOfNotNan = double.IsNaN(notNan);

                double infinity = 0.1 / 0.0;
                double notInfinity = 0.0 / 0.0;
                bool resultOfInf = double.IsInfinity(infinity);
                bool resultOfNotInf = double.IsInfinity(notInfinity);

                double epl = double.Epsilon;
                double epilsonValue = 4.94065645841247E-324;
                double one = 0.1;

                bool whichIsGreater = one > epilsonValue;
                
            }

            {
                /*
                 1. true;
                 2. 'A';
                 3. 5;
                 4. "Salam";
                 5. 18 dene 9 reqemini saxlasin
                 999999999999999999
                 */
                bool booleanVar = true;
                char aChar = 'A';
                byte byteVar = 5;
                string stringVar = "Salam";
                long l = 999999999999999999; 
            }

            {
                //Decimal
                //hecmi: 16 byte
                //precision: 28-29
                decimal d = 1.5615615615615615615156156156m;
                decimal decimalVar = 10.2m;
                decimal decMinVal = decimal.MinValue;
                decimal decMaxVal = decimal.MaxValue;

                decimal minusOneValue = decimal.MinusOne;

                //byte decimalToByte = decimal.ToByte(10000000); //(xeta)
                //sbyte decimalToSbyte = decimal.ToSByte(10000000); //(xeta)

                short decimalToShort = decimal.ToInt16(500);
                int decimalToInt = decimal.ToInt32(222156);
                long decimalToBigInt = decimal.ToInt64(156156156156156156);
            }

            {
                //Float
                //hecmi: 4byte / 32 bit
                //precision: 7
                float minValue = float.MinValue;
                float maxValue = float.MaxValue;
                float floatVar = 10.2F;
            }

            {
                DateTime now = DateTime.Now;
                DateTime utcNow = DateTime.UtcNow;

                long ticks = now.Ticks;
                int milliSec = now.Millisecond;
                int second = now.Second;
                int minute = now.Minute;
                int hour = now.Hour;
                int day = now.Day;
                DayOfWeek dayOfWeek = now.DayOfWeek;
                int month = now.Month;
                int year = now.Year;
                TimeSpan timeOfDay = now.TimeOfDay;
                string shortDate = now.ToShortDateString();
                string longDate = now.ToLongDateString();
                string shortTime = now.ToShortTimeString();
                string longTime = now.ToLongTimeString();
                string timeFormat = now.ToString("MM/dd/yyyy HH:mm:ss");
                string timeFormat1 = now.ToString("MMMM dd");
                string timeFormat2 = now.ToString("dddd, dd MMMM yyyy");
                string timeFormat3 = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");

                DateTime monthChanged = now.AddMonths(2);
                DateTime dayChanged = now.AddDays(5);
                DateTime hourChanged = now.AddHours(2);
                DateTime minusHours = now.AddHours(-5);

                DateTime specificDate = new DateTime(1990, 12, 24);
                DateTime specificDateAndTime = new DateTime(1995, 12, 24, 10, 05, 59, 999);
            }

            //Object type
            //hecmi 4 byte
            //deyer araligi: butun C# obyektleri

            object stringValue = "My string";
            object intValue = 5;
            object boolValue = true;
            object charValue = 'G';
            object dateTimeValue = new DateTime();

            Console.WriteLine(stringValue);
            Console.WriteLine(intValue);
            Console.WriteLine(boolValue);
            Console.WriteLine(charValue);
            Console.WriteLine(dateTimeValue);
            #endregion

            #region Task 4
            // 10.5 double,
            // 20.5 decimal,
            // 30.5 float
            double d1 = 10.5;
            decimal d2 = 20.5M;
            float f1 = 30.5F;
            float f2 = f1;
            #endregion

            #region Assign one to another
            string orkhan = "Orkhan Farajov";
            string john = "John Farajov";

            orkhan = john;
            john = orkhan;

            orkhan = "hello";
            john = "hi";

            int fiveHundred = 500;
            int fiveHundredCopied = fiveHundred;

            bool isWinterCold = true;
            bool isSummerWarm = isWinterCold;
            isWinterCold = false; //Eger isti iqlimli olke ucundurse deyeri sonradan deyisdirilir

            char p = 'P';
            char otherChar = p;
            #endregion

            #region Task 5
            /*
             1. indiki zamani saxlasin
             2. 20 dekabr 2020
             */
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = new DateTime(2020, 12, 20);
            #endregion

            #region Default values of data types
            //reference types
            string defaultString;
            object defaultObject;
            Student defaultClass;

            //value-types
            char defaultChar;
            byte defaultByte;
            short defaultShort;
            int defaultInt;
            long defaultLong;
            double defaultDouble;
            decimal defaultDecimal;
            float defaultFloat;
            bool defaultBoolean;
            DateTime defaultDateTime;
            #endregion

            #region Local vs Global Variables
            Console.WriteLine(Country);

            ShowCountry();

            int myLocalVar = 5;
            Console.WriteLine(myLocalVar);
            #endregion

            int globalVar = 0;

            {
                int localVar1 = 555;
                globalVar += localVar1;
            }

            {
                int localVar2 = 45;
                globalVar += localVar2;
            }

            {
                int localVar3 = 50;
                globalVar += localVar3;
            }




            //Level 5 - Butun skoplara gore global ve el catan (Main skopu icinde)
            int level5 = 500;
            //level4 -= 100; //level4 does not exist
            //level3 -= 100; //level3 does not exist
            //level2 -= 100; //level2 does not exist
            //level1 -= 100; //level1 does not exist
            {
                //Level 4 - alt skoplara gore global, ust skoplara gore local
                int level4 = 400;
                level5 -= 100;
                //level3 -= 100; //level3 does not exist
                
                {
                    //Level 3 - alt skoplara gore global, ust skoplara gore local
                    int level3 = 300;
                    level5 -= 100;
                    level4 -= 100;
                    //level2 -= 100; //level2 does not exist
                    //level1 -= 100; //level1 does not exist
                    {
                        //Level 2 - alt skoplara gore global, ust skoplara gore local
                        int level2 = 200;
                        level5 -= 100;
                        level4 -= 100;
                        level3 -= 100;
                        //level1 -= 100; //level1 does not exist

                        {
                            //Level 1 - alt skoplara gore global, ust skoplara gore local
                            int level1 = 100;
                            level5 -= 100;
                            level4 -= 100;
                            level3 -= 100;
                            level2 -= 100;
                        }
                    }
                }
            }

            int globalAge;

            {
                int localAge = 27;
                globalAge = localAge;
            }

            {
                Student localStudent = new Student();
                localStudent.Age = globalAge;
            }
        }

        public static void ShowCountry()
        {
            Console.WriteLine(Country);

            //Console.WriteLine(myLocalVar); //myLocalVar is local
        }


    }
}
