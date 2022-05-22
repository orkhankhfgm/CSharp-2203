using System;

namespace OOP___Inheritance_part_1_homework
{
    public class Employee : Person
    {
        public DateTime DateOfStartWorking { get; set; }
        public DateTime DateOfEndWorking { get; set; }
        public int RestDays { get; set; }
    }
}
