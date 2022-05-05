namespace Encapsulation
{
    class Customer
    {
        public int Id;
        public string Name;
        public string Surname;
        private string email;

        public string Email {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string ShortGetSet { get; set; }
    }
}
