namespace Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.SayHi();

            Employee orkhan = new Employee("Orkhan", "Farajov", "orkhan");

            Employee fuad = new Employee("Fuad", "Teymurov", "fuad");

            Employee samir = new Employee("Samir", "Babayev", "samir");

            var domain = Employee.domain;


            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
        }
    }
}
