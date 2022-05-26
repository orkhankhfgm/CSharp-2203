namespace Virtual_Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Virtual
            Customer customer = new Customer("Orkhan", "Farajov");
            //customer.Name = "Orkhan";
            //customer.Surname = "Farajov";

            var toString = customer.ToString();



            Person person = new Person();
            person.Name = "Cavid";
            person.Surname = "Cavidov";
            person.Age = 50;
            var toStr = person.ToString();

            int a = 5;
            string b = a.ToString();



            Item item = new Item();
            item.ShowText("ShowText called from Item");

            BaseClass bc = new BaseClass();
            bc.ShowText("ShowText called from Item");

            Item item1 = new Item();
            item1.WriteText("WriteText called from Item");

            BaseClass bc1 = new BaseClass();
            bc1.WriteText("WriteText called from Item");
            #endregion
        }
    }
}
