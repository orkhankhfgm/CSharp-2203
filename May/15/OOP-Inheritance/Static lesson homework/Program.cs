namespace Static_lesson_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Email = "orkhankhf@gmail.com",
                Username = "orkhankhf",
                Password = "1Orxandscdsc"
            };

            Customer.AddCustomer(customer1);



            Customer customer2 = new Customer()
            {
                Id = 1,
                Name = "Fuad",
                Surname = "Teymurov",
                Email = "fuad@gmail.com",
                Username = "fuad",
                Password = "1Fuaddscdsc"
            };

            Customer.AddCustomer(customer2);

            Customer customer3 = new Customer()
            {
                Id = 1,
                Name = "Fuad",
                Surname = "Teymurov",
                Email = "fuad@gmail.com",
                Username = "fuad",
                Password = "11Fuaddscdsc"
            };

            Customer.AddCustomer(customer3);
        }
    }
}
