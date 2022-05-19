namespace OOP___Inheritance_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            Student student = new Student();

            Person person = new Person();
            person.GoodPerson();

            Teacher teacher2 = new Teacher();
            teacher2.GoodPerson();

            #region Assignment sub class to parent class
            Student student1 = new Student();
            object obj = student1;

            //Student st1 = obj; need casting
            Student s1 = (Student)obj;
            Person p1;

            p1 = s1;
            p1 = new Teacher();

            //s1 = new Person(); //(error)
            p1 = new Student()
            {
                Id = 1,
                Name = "Test"
            };

            object objPerson = new Person();
            object objTeacher = new Teacher();
            object objStudent = new Student();
            #endregion
        }
    }
}
