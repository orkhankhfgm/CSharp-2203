using System;

namespace Static_Classes
{
    public static class ExampleConstructorClass
    {
        //public ExampleConstructorClass() //Error!
        //{
        //
        //}

        static ExampleConstructorClass()
        {
            Console.WriteLine("ctor...");
        }

        public static void ShowPersonInfo()
        {
            Console.WriteLine("Name: Orkhan");
            Console.WriteLine("Surname: Farajov");
            Console.WriteLine("Age: 27");
        }
    }
}
