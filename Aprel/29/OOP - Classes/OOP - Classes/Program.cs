using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müştəri
            //Satış Meneceri
            //Satılacaq məhsul (Avtomobil, moto, gəmi)
            //Təklif
            //Sifariş
            //Qəbz


            /*
            Müştəri
                Ad
                Soyad
                Cinsiyyət
                Pasport seriya və nömrə
                Ünvanı
            
            Məhsul
                Marka
                Model
                İl
                Km
                Yanacaq növü
                Ban növü
            
            Təklif
                Təklif nömrəsi
                Müştəri
                Satıcı
                Məhsul
                Qiymət
            
            Sifariş
                Sifariş nömrəsi
                Təklif
                Qiymət

            Qəbz
                Vergi nömrəsi
                Qəbz nömrəsi
                Seriya
                Təklif
                Müştəri
             */

            string name = "Orkhan";

            Customer customer = new Customer();
            customer.Name = "Orkhan";
            customer.Surname = "Farajov";
            customer.Gender = 1;
            customer.Address = "Baki, Nerimanov, Rasim Axundov, No 5";


            Customer otherCustomer = new Customer();
            otherCustomer = customer;

            otherCustomer.Name = "Name changed for otherCustomer";
            customer.Surname = "Surname changed for customer";

            customer = null;
            otherCustomer = null;

            //string customerName = otherCustomer.Name;


            Customer defaultCtor = new Customer();
            Customer overload1 = new Customer("123456");
            Customer overload2 = new Customer("123456", "AZ");
            Customer overload3 = new Customer("123456", "AZ", "Orkhan", "Farajov");
            Customer overload4 = new Customer(1, "Orkhan", "Farajov");
            Customer overload5 = new Customer("123456", "AZ", 1, "Orkhan", "Farajov", "Baki seh.");

            overload1.CheckCustomer();


        }
    }
}
