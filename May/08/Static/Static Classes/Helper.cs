using System;

namespace Static_Classes
{
    public static class Helper
    {
        public static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        //Can't create non static constructor in static class
        //public Helper()
        //{

        //}
    }
}
