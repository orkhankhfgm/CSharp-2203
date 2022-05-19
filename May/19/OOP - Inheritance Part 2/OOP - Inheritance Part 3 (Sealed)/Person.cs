using System;

namespace OOP___Inheritance_Part_3__Sealed_
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }

        public Person()
        {
            Console.WriteLine("CTOR: Person class");
        }

        #region Protected access modifier
        protected void MyProtectedMethod()
        {
            Console.WriteLine("This method is protected");
        }

        public void ReachProtectedMethod()
        {
            MyProtectedMethod();
        }
        #endregion
    }
}
