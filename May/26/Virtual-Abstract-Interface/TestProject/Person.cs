using System;

namespace TestProject
{
    public class Person : Base, IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymc { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
