namespace OOP___Classes
{
    class Customer
    {
        public string Name;
        public string Surname;
        public int Gender; //1: Kisi 2: Qadin
        public string DocumentSerial { get; set; }
        public string DocumentNumber { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            DocumentNumber = "000000";
            DocumentSerial = "AZ";
        }

        public Customer(string documentNumber)
        {
            DocumentNumber = documentNumber;
        }

        public Customer(string documentNumber, string documentSerial)
        {
            DocumentNumber = documentNumber;
            DocumentSerial = documentSerial;
        }

        public Customer(string documentNumber, string documentSerial, string name, string surname)
        {
            DocumentNumber = documentNumber;
            DocumentSerial = documentSerial;
            Name = name;
            Surname = surname;
        }

        public Customer(int gender, string name, string surname)
        {
            Gender = gender;
            Name = name;
            Surname = surname;
        }

        public Customer(string documentNumber, string documentSerial, int gender, string name, string surname, string address)
        {
            DocumentNumber = documentNumber;
            DocumentSerial = documentSerial;
            Gender = gender;
            Name = name;
            Surname = surname;
            Address = address;
        }



        private bool CheckCustomerFromDb()
        {
            return true;
        }

        public bool CheckCustomer()
        {
            bool result = CheckCustomerFromDb();
            return result;
        }
    }
}
