using System;

namespace InnerType
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                DocumentNo = 5555,
                BirthDate = DateTime.Now,
                CreateDate = DateTime.Now
            };

            Country country = new Country()
            {
                Id = 1,
                Name = "Azerbaijan"
            };

            City city = new City()
            {
                Id = 1,
                Name = "Baku",
                Country = country,
                CreateDate = DateTime.Now
            };

            customer.Addresses[0] = new Address()
            {
                Id = 1,
                No = 5,
                Building = "My Building",
                Street = "My Street",
                Distinct = "My Distinct",
                City = city,
                CreateDate = DateTime.Now
            };

            customer.Addresses[1] = new Address()
            {
                Id = 2,
                No = 40,
                Building = "My Office Building",
                Street = "My Office Street",
                Distinct = "My Office Distinct",
                City = city,
                CreateDate = DateTime.Now
            };

            customer.Contacts[0] = new Contact()
            {
                Id = 1,
                Email = "orkhankhf@gmail.com",
                PhoneNumber = "+994555810872",
                CreateDate = DateTime.Now
            };

            customer.Orders[0] = new Order()
            {
                Id = 1,
                OrderDetails = "Asus tuf fx705gm",
                ShippingDetails = customer.Addresses[0],
                CreateDate = DateTime.Now
            };

            Order orderPhone = new Order()
            {
                Id = 2,
                OrderDetails = "Microphone",
                ShippingDetails = customer.Addresses[1],
                CreateDate = DateTime.Now
            };

            customer.Orders[1] = orderPhone;

            //customer.ShowAddresses();
            //customer.ShowContacts();
            //customer.ShowOrders();
            customer.ShowAllInfo();
            Console.ReadLine();

            //Student st = new Student();
            //var stName = st.Name.ToString();
            //var bDate = st.BirthDate.Year;
            //var add = st.Address.Distinct;

            Customer[] customers = new Customer[2];
            customers[0] = new Customer();
            customers[1] = new Customer();

            foreach (var c in customers)
            {
                Console.WriteLine(c.Name + " " + c.Surname);

                foreach (var adress in c.Addresses)
                {
                    Console.WriteLine(adress.Street);
                }
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
