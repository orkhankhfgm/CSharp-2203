namespace Virtual_Abstract_Interface
{
    public class Customer : Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer(string name, string surname)
        {
            this.Name = base.Name = name;
            this.Surname = base.Surname = surname;
        }


        //private string _name { get; set; }
        //public string Name {
        //    get { return _name; }
        //    set {
        //        _name = value;
        //        base.Name = _name;
        //    }
        //}

        //private string _surname { get; set; }
        //public string Surname {
        //    get { return _surname; }
        //    set {
        //        _surname = value;
        //        base.Surname = _surname;
        //    }
        //}
    }
}
