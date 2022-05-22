using System;

namespace InnerType
{
    public class Customer : BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime BirthDate { get; set; }

        #region Inner Type required fields
        public Contact[] Contacts;
        public Address[] Addresses;
        public Order[] Orders;
        #endregion

        public Customer()
        {
            Contacts = new Contact[100];
            Addresses = new Address[100];
            Orders = new Order[100];
        }

        public void ShowAllInfo()
        {
            ShowAddresses();
            ShowContacts();
            ShowOrders();
        }

        public void ShowAddresses()
        {
            Console.WriteLine("Adress Details for Customer {0} {1}", Name, Surname);
            int count = 1;

            foreach (var item in Addresses)
            {
                if (item is null)
                    break;

                Console.WriteLine("{0}. Address Details:", count);
                Console.WriteLine("Country: " + item.City.Country.Name);
                Console.WriteLine("City: " + item.City.Name);
                Console.WriteLine("Distinct: " + item.Distinct);
                Console.WriteLine("Street: " + item.Street);
                Console.WriteLine("Building: " + item.Building);
                Console.WriteLine("No: " + item.No);
                count++;
            }
        }

        public void ShowContacts()
        {
            Console.WriteLine("Contact Details for Customer {0} {1}", Name, Surname);
            int count = 1;

            foreach (var item in Contacts)
            {
                if (item is null)
                    break;

                Console.WriteLine("{0}. Contact Details:", count);
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Email: " + item.Email);
                Console.WriteLine("PhoneNumber: " + item.PhoneNumber);
                Console.WriteLine("CreateDate: " + item.CreateDate);

                if (item.EditDate == null)
                    Console.WriteLine("Data is not edited");
                else
                    Console.WriteLine(item.EditDate.Value.ToString("dd.mm.yyyy"));

                //Console.WriteLine("EditDate: " + (item.EditDate == null ? "Data is not edited" : item.EditDate.Value.ToString("dd.mm.yyyy")));
                count++;
            }
        }

        public void ShowOrders()
        {
            Console.WriteLine("Order Details for Customer {0} {1}", Name, Surname);
            int count = 1;

            foreach (var item in Orders)
            {
                if (item is null)
                    break;

                Console.WriteLine("{0}. Order Details:", count);
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Order Details: " + item.OrderDetails);
                Console.WriteLine("CreateDate: " + item.CreateDate);
                Console.WriteLine("EditDate: " + (item.EditDate == null ? "Data is not edited" : item.EditDate.Value.ToString("dd.mm.yyyy")));
                Console.WriteLine("Shipping Address Details for order: "+ item.Id);
                Console.WriteLine("Country: " + item.ShippingDetails.City.Country.Name);
                Console.WriteLine("City: " + item.ShippingDetails.City.Name);
                Console.WriteLine("Distinct: " + item.ShippingDetails.Distinct);
                Console.WriteLine("Street: " + item.ShippingDetails.Street);
                Console.WriteLine("Building: " + item.ShippingDetails.Building);
                Console.WriteLine("No: " + item.ShippingDetails.No);
                count++;
            }
        }
    }
}
