﻿namespace Virtual_Abstract_Interface
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + Surname + Age;
        }
    }
}
