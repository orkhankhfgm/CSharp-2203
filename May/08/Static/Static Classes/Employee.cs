namespace Static_Classes
{
    public class Employee
    {
        public static string domain;
        public string Name { get; set; }
        public string Surname { get; set; }

        private string _email;

        public string Email
        {
            get { return this._email; }
            set { this._email = value.ToLower() + "@" + Employee.domain; }
        }

        public Employee(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }

        static Employee()
        {
            domain = "google.com";
        }
    }
}
