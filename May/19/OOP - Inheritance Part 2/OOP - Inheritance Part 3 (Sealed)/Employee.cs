namespace OOP___Inheritance_Part_3__Sealed_
{
    public class Employee : Person
    {
        public string Sector { get; set; }
        public int WorkType { get; set; } //PartTime=0 / FullTime=1
        public decimal Salary { get; set; }
    }
}
