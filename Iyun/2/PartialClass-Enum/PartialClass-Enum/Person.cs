using PartialClass_Enum.Enum;
using System;

namespace PartialClass_Enum
{
    public class Person : BaseClass<Person>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public int GenderInteger { get; set; }

        public override int Add(Person item)
        {
            return 1;
        }

        public override bool Delete(int id)
        {
            return true;
        }

        public override Person Get(int id)
        {
            return new Person();
        }

        public override Person[] GetAll(int id)
        {
            return new Person[10];
        }

        public override Person Update(Person item)
        {
            return new Person();
        }
    }
}
