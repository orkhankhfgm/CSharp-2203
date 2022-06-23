using System.Collections.Generic;

namespace WindowsFormsAppPart2
{
    public class VirtualDatabase
    {
        public static List<User> Users = new List<User>();

        static VirtualDatabase()
        {
            Users.Add(new User() {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Username = "orkhanfarajov",
                Password = "orkhan123456"
            });

            Users.Add(new User() {
                Id = 1,
                Name = "Fuad",
                Surname = "Teymurov",
                Username = "fuadteymurov",
                Password = "fuad123456"
            });

             Users.Add(new User() {
                Id = 1,
                Name = "Vəfa",
                Surname = "Qarayeva",
                Username = "vefaqarayeva",
                Password = "vefa123456"
            });
        }
    }
}
