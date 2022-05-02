using System;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() {
                Id = 1,
                Name = "Orkhan5",
                Surname = "Farajov"
            };

            Registration.RegisterNewUser(user);


            //Console.WriteLine("ID: " + logged.Id);
            //Console.WriteLine("Name: " + logged.Name);
            //Console.WriteLine("Surname: " + logged.Surname);

            User.ShowUserInfo(new User());


        }
    }
}
