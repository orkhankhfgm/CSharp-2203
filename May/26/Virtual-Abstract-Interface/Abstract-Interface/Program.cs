namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Test();
            customer.ShowTime();

            //CRUD

            //Create
            //Read
            //Update
            //Delete

            VipCustomer vip = new VipCustomer();
            vip.ShowTime();


            Student student = new Student();
            student.Name = "Orxan";
        }
    }
}
