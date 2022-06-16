using System;
using System.Collections.Generic;

namespace GenericCollections_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is NOT Generic Class
            Customer customer = new Customer();

            GenericCustomer<string> gCustomer = new GenericCustomer<string>();
            gCustomer.Id = 5;
            gCustomer.Name = "Orkhan";
            gCustomer.Surname = "Farajov";
            gCustomer.DateOfBirth = new DateTime(1995, 12, 24);
            gCustomer.DocumentSerial = "AA";
            gCustomer.DocumentNo = "123456";
            gCustomer.PlaceOfBirth = "Baku";



            MultipleGenericClass<string, int, DateTime> multiGeneric = new MultipleGenericClass<string, int, DateTime>();
            multiGeneric.Id = 1;
            multiGeneric.Name = "Orkhan";
            multiGeneric.Surname = "Farajov";
            multiGeneric.DateOfBirth = new DateTime(1995, 12, 24);

            string name = multiGeneric.GetName();



            MultipleGenericClass<int, string, DateTime> multiGeneric1 = new MultipleGenericClass<int, string, DateTime>();
            multiGeneric1.Id = "salam";
            multiGeneric1.Name = 1;
            multiGeneric1.Surname = 2;
            multiGeneric1.DateOfBirth = new DateTime(1995, 12, 24);

            int name1 = multiGeneric1.GetName();
            #endregion



            #region What is Generic Class
            /*
             Database      |        App
             MsSQL         |        C#


             Database terefde, Table=Class, Column=Property, Row=data
             */

            GenericRepository<Customer> customerRepository = new GenericRepository<Customer>();
            List<Customer> customers = customerRepository.Get();

            GenericRepository<Item> itemRepository = new GenericRepository<Item>();
            List<Item> items = itemRepository.Get();

            Customer cust = new Customer() {
                Id = 5,
                Name = "Orkhan",
                Surname = "Farajov",
                DateOfBirth = new DateTime(1995, 12, 24),
                DocumentSerial = "AA",
                DocumentNo = "123456",
                PlaceOfBirth = "Baku"
            };

            Item item = new Item() {
                Id = 1,
                Name = "Some item name",
                Description = "Some description",
                Price = 100m,
                MadeInCountry = "China"
            };

            customerRepository.Add(cust);
            itemRepository.Add(item);


            RestrictGenericClassWithType<Student> restrictedGenericClass = new RestrictGenericClassWithType<Student>();
            restrictedGenericClass.StructTypeProperty = new Student() {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov"
            };
            #endregion
        }
    }
}
