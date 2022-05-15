using System;
using System.Collections;

namespace Static_lesson_homework
{
    public class Customer
    {
        #region Virtual Database
        private static ArrayList database;
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        #endregion

        #region Encapsulation
        private string _username { get; set; }
        private string _password { get; set; }

        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                bool isUsernameDuplicate = CheckDuplicateUsername(value);

                if (isUsernameDuplicate)
                    Console.WriteLine("Elave etdiyiniz username artiq var");
                else
                    this._username = value;
            }
        }

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                bool isPasswordValid = IsPasswordValid(value);
                if (!isPasswordValid)
                    Console.WriteLine("Sifre en az 8 simvol olmalidir ve icinde 1 boyuk herf ve 1 reqem olmalidir.");
                else
                    this._password = value;
            }
        }
        #endregion

        #region Static methods
        static bool CheckDuplicateUsername(string username)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Customer tempCustomer = (Customer)database[i];

                if (tempCustomer.Username == username)
                    return true;
            }
            return false;
        }

        static bool CheckDuplicateEmail(string email)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Customer tempCustomer = (Customer)database[i];

                if (tempCustomer.Email == email)
                    return true;
            }

            return false;
        }

        static bool IsPasswordValid(string password)
        {
            bool valid = false, upperLetter = false, number = false;

            if(password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                        upperLetter = true;

                    if (char.IsNumber(password[i]))
                        number = true;
                }

                valid = (upperLetter && number);
            }

            return valid;
        }

        public static void AddCustomer(Customer customer)
        {
            if(customer != null && !string.IsNullOrEmpty(customer.Username) && !string.IsNullOrEmpty(customer.Email))
            {
                bool isEmailDuplicate = CheckDuplicateEmail(customer.Email);

                if (isEmailDuplicate)
                    Console.WriteLine("Elave etdiyiniz email artiq movcuddur.");
                else
                {
                    database.Add(customer);
                    Console.WriteLine("Yeni musteri sisteme elave edildi!");
                }                    
            }
        }
        #endregion

        #region Constructor
        static Customer()
        {
            database = new ArrayList();
        }
        #endregion
    }
}
