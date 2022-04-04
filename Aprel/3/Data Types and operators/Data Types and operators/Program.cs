using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region User Defined Conversion
            {
                Student student = new Student("Orkhan", "Farajov", 27);
                string strStudent = student;
                string strStudentCast = (Student)student;
                string strStudentToString = student.ToString();

                short a = 15;
                int b = a;
            }
            #endregion

            #region Boxing and Unboxing
            {
                //Boxing
                //Implicit
                int valueType = 15; //stack
                object referanceType = valueType; //heap

                //Explicit
                object otherRefType = (object)valueType;




                //implicit boxing
                int a = 100;
                object o = a;
                //explicit unboxing
                int unboxing = (int)o;

                byte b5 = 1;
                int error2 = (byte)b5;
            }
            #endregion

            #region Convert, Parse and TryParse
            string textNumber = "100";

            //with Convert
            int convertToInt = Convert.ToInt32(textNumber);

            //with parse method
            int parseToInt = int.Parse(textNumber);

            //with tryParse
            int integerValue;
            int integerValue2;

            string notNumberString = "5salam";
            bool badResult = int.TryParse(notNumberString, out integerValue);

            string numberString = "5";
            bool goodResult = int.TryParse(numberString, out integerValue2);

            #region Task in Lesson 1
            /*
             Bir boolean tipində dəyişəniniz olsun və dəyəri də true olsun. Bir dənə də int tipində dəyişən yaradıb
             dəyərini 1 set edəcəksiniz. Bu int tipində olan dəyişənə dəyəri set edəndən sonra elə edin ki, boolean
             tipində dəyişəni necəsə konvertasiya edib 0 dəyərini əldə edəsiniz.
             */
            bool booleanVar = true;
            string stringVar = Convert.ToString(booleanVar);
            int resultOfTryParse = 1;
            bool parse = int.TryParse(stringVar, out resultOfTryParse);
            resultOfTryParse = Convert.ToInt32(parse);
            #endregion


            string nullString = null;
            int nullConvertResult = Convert.ToInt32(nullString); //returns default value of target type
            //int nullParseResult = int.Parse(nullString); //error while runtime
            int nullOutVal = 2;
            bool tryParseNull = int.TryParse(nullString, out nullOutVal);

            string notIntString = "A";
            //int notIntConvertResult = Convert.ToInt32(notIntString); //error while runtime
            //int notIntParseResult = int.Parse(notIntString); //error while runtime
            int notIntOutVal = 2;
            bool tryToParseNotInt = int.TryParse(notIntString, out notIntOutVal);

            #region Task in Lesson 2
            /*
             1. İki dənə int tipində dəyişəniniz olacaq. Birinin dəyəri 1, digərinin dəyəri 0 olacaq. Sonra bu iki dənə 
                boolean tipində başqa dəyişəniniz olacaq və bu iki int tipində olan dəyişəninizi digər iki boolean tipində
                dəyişənə çevirəcəksiz.

             2. Bir dənə DateTime tipində dəyişəniniz olsun və indiki zamanı götürün. Sonra o dəyişəni bir başqa object tipindəki
                dəyişənə mənimsədin. Yəni Boxing. Sonra DateTime tipində 3-cü bir dəyişən yaradın və 2-ci yaratdığınız object'in
                dəyərini 3-cü yaratdığınız DateTime tipində olan dəyişənə verin.

             3. İki string tipində dəyişəndə True və False sözlərini saxlayın. Sonra bu string'ləri bool tipində bir dəyişənə çevirin.
                Convert'dən istifadə etmək olmaz.
             */
            //1
            {
                int falseVal = 0;
                int trueVal = 1;
                bool falseBool = Convert.ToBoolean(falseVal);
                bool trueBool = Convert.ToBoolean(trueVal);

                //2
                DateTime now = DateTime.Now;
                object objDate = now;
                var dateFromObject = Convert.ToDateTime(objDate);

                //3
                string trueText = "True";
                bool trueFromText = bool.Parse(trueText);

                string falseText = "False";
                bool falseFromText = bool.Parse(falseText);
            }
            #endregion
            #endregion

            #region Constant
            double pi = 3.14;
            //bir ay kecdi
            pi = 5.20;

            const double piConst = 3.14;
            //piConst = 5.20; //Value of const can't be changed

            int someInteger;
            someInteger = 5;

            const double secondConstDouble = piConst;

            int no;
            no = 100;

            decimal dec;
            dec = 45.6M;

            string name;
            name = "Orkhan";

            DateTime dt;
            dt = DateTime.Now;

            //const decimal aa;
            //aa = 100;
            const int number = 500; //value must be set while creating instance
                                    //const int buildingNo = no; //can't assign not constant value to constant value.
            #endregion

            #region Var keyword
            int someNumber = 1;
            string text = "Hello baby";
            decimal dec1 = 45.5M;
            DateTime dt2 = DateTime.Now;

            var numberVar = 1;
            var textVar = "Hello baby";
            var dec1Var = 45.5M;
            var dt2Var = DateTime.Now;

            //type inference
            //IL (arasdirin)
            //MSIL (arasdiin)

            object o5 = "salam";
            o5 = 2;
            o5 = true;


            object objVariable = 1;
            objVariable = "Test";

            int seeIntMethods = 1;
            string seeStringMethods = "Some string";

            object obj = seeStringMethods;
            #endregion


            int num1, num2, num3;
            string name1, surname, fatherName, BirthPlace;
            DateTime startDate, endDate;

            int no1 = 10, no2 = 20, no3 = 30;


            #region Operators
            /*
             1. Unary: a++, b--, !true;
             2. Binary: a+ b, a > b, a = b;
             3. Ternary: a > b ? "" : ""; (shorthand if else)
             Operator nədir?: +, -, *, /, !, !=
             Operand nədir?: a, b, (dəyişənlər və s.)

             1. Arithmetic (hesablama)
             2. Logical (məntiqi)
             3. Special (xüsusi)
             4. Assignment (mənimsəmə)
             5. Comparsion (qarşılaşdırma)
             */

            decimal x = 100, y = 5, i = 0;

            //Arithmetic (hesablama)
            i = x + y;
            i = x - y;
            i--; //(i = i - 1 ilə eynidir)
            i++; //(i = i + 1 ilə eynidir)
            i = i - 1;
            i = i + 1;
            i -= 5;
            i += 5;
            i = y * 5;
            i = x / 6; //(16)
            i = x * y;
            i = x / y;
            i = x % y;
            int m = 10 % 2;
            m = 11 % 2;
            string country = "Azerbaijan";
            string city = "Baku";
            string address = country + ", " + city;

            //Logical (məntiqi)
            {
                bool trueBool = true, falseBool = false, res;
                res = !trueBool;
                res = !falseBool;
                res = !falseBool || !trueBool;
                res = !falseBool && !trueBool;
                res = 5 == 5 && 4 == 10;
                res = 5 == 5 || 4 == 10;
            }

            //Assignment (mənimsəmə)
            int assign = 100;
            assign += 5;
            assign -= 5;
            assign /= 5;
            assign *= 5;
            assign %= 2;
            string person = "Orkhan Farajov";
            person += " is developer";
            //person = person + " is developer";

            //Comparsion (qarşılaşdırma)
            int c = 100;
            int d = 50;
            string firstname1 = "Orkhan";
            string firstname2 = "John";
            bool compareRes;

            compareRes = c > d;
            compareRes = c < d;
            compareRes = c == d;
            compareRes = c != d;
            compareRes = c <= d;
            compareRes = c >= d;
            compareRes = firstname1 == firstname2;
            compareRes = firstname1 != firstname2;
            {
                bool res;
                res = (10 / 2) == 5;
                res = (10 / 2) != 5;
            }


            //Special (xüsusi operatorlar) sizeof, typeof, new, checked, unchecked, as, is
            //sizeof
            int sizeOfsByte = sizeof(sbyte);
            int sizeOfByte = sizeof(byte);
            int sizeOfInt16 = sizeof(Int16);
            int sizeOfshort = sizeof(short);
            int sizeOfInt32 = sizeof(Int32);
            int sizeOfInt = sizeof(int);
            int sizeOfInt64 = sizeof(Int64);
            int sizeOfLong = sizeof(long);
            int sizeOfuLong = sizeof(ulong);
            int sizeOfuInt = sizeof(uint);
            int sizeOfBool = sizeof(bool);

            //typeof
            Type type1 = typeof(int);
            Type type2 = typeof(Int32);
            bool compareIntAndInt32 = type1 == type2;

            Type type3 = typeof(int);
            Type type4 = typeof(int);
            bool compareIntAndInt = type3 == type4;

            //new
            DateTime dt1 = new DateTime();

            //is
            int otherInt = 25;
            bool isOtherInt_String = otherInt is string;
            bool isOtherInt_Int = otherInt is int;
            bool isOtherInt_Int32 = otherInt is Int32;
            bool isOtherInt_Int64 = otherInt is Int64;
            bool isOtherInt_Object = otherInt is object;
            Int32 i32 = otherInt;
            object o32 = i32;

            //as
            object objectName = "Orkhan";
            object objectNum = 5;
            string sName = objectName as string; 
            string sText = objectName as string;
            int? aaa = objectNum as int?;

            decimal d5 = 10;
            float? f5 = d5 as float?;

            //nullable types
            string a1 = null;
            int? b1;
            DateTime? dt5;

            //10 * 20 / 5 = 40
            float u = 10 * 20 + 10;
            float u2 = 10 * (20 + 10);
            float u3 = ((10 * (20 + 10) + 5) * 2);

            bool b2 = (5 == 5 || 10 == 10) && (9 > 10 && 2 == 2);
            #endregion
        }
    }
}
