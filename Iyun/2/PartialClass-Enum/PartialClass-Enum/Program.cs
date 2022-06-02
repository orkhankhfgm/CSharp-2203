using PartialClass_Enum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Id = 1;
            book.CreateDate = DateTime.Now;
            book.CreateUser = 100;
            book.Code = 100001212;
            book.Genre = "SomeGenre";
            book.Publisher = "SomePublisher";
            book.Cover = "SomeCover";
            book.Author = "SomeAuthor";
            book.Page = 356;
            book.Language = "ENG";

            book.Add(book);
            book.Update(book);
            book.Delete(1);




            Car car = new Car();
            car.Id = 5;
            car.CreateDate = DateTime.Now;
            car.CreateUser = 100;
            car.Brand = "Mercedes";
            car.Model = "GL550";
            car.Door = 5;
            car.SeatCount = 6;
            car.Engine = 5000;

            car.Add(car);
            car.Update(car);
            car.Delete(1);



            Person person = new Person();
            person.Name = "Orkhan";
            person.Surname = "Farajov";
            person.DateOfBirth = new DateTime(1995, 12, 24);
            person.Gender = GenderEnum.Male;
            person.GenderInteger = (int)GenderEnum.Male;

            if(person.Gender == GenderEnum.Male)
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person is Female");


            if(person.Gender.Equals(GenderEnum.Male))
                Console.WriteLine("Gender is equal to Male");
            else
                Console.WriteLine("Gender isn't equal to Male");

            if(person.GenderInteger == (int)GenderEnum.Male)
                Console.WriteLine("Gender is Male");
            else
                Console.WriteLine("Gender isn't Male");

        }
    }
}
