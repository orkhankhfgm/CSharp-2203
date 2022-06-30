using System;

namespace WindowsFormsAppPart3
{
    public class Customer
    {
        public Guid Id { get; set; }
        //Example guid: 1fg5b1fg15b-4fgb145-1f5gbbfg
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + FatherName + " " + Email + " " + PhoneNumber;
        }
    }
}
