using System;

namespace Questions
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //User'in instance'i yaradilan zaman gedir ram'a dusur
        public static User GetUserDetails(int userId)
        {
            //Connect to database

            User loginUser = new User() {
                Id = userId,
                Name = "Orkhan",
                Surname = "Farajov"
            };
            ShowUserInfo(loginUser);
            return loginUser;
        }

        //proqram run olundugu anda ram'da yaranir
        public static void ShowUserInfo(User user)
        {
            var x = GetUserDetails(1);
            Console.WriteLine("ID: " + user.Id);
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Surname: " + user.Surname);
        }
    }
}
