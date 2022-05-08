namespace Static
{
    public class Staff
    {
        public static string domain = "oxu.az";
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }

        private string _email;

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value.ToLower() + "@" + domain /*və ya*/   /*Staff.domain*/;
            }
        }
    }
}
