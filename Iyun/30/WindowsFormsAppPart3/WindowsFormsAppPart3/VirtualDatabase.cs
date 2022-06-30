using System.Collections.Generic;

namespace WindowsFormsAppPart3
{
    public class VirtualDatabase
    {
        public static List<Customer> Customers { get; set; }

        static VirtualDatabase()
        {
            Customers = new List<Customer>();
        }
    }
}
