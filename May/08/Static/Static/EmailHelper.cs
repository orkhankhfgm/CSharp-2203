using System;

namespace Static
{
    public class EmailHelper
    {
        public static void SendWelcomeMail(string receiver)
        {
            Console.WriteLine("Bu methodda xos gelmisiniz emaili gonderilir...");
        }

        public static void SendPasswordChangeMail(string receiver)
        {
            Console.WriteLine("Bu methodda sifre deyisdirilme emaili gonderilir...");
        }
    }
}
