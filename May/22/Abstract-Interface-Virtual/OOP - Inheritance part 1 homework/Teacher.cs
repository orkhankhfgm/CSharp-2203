using System;

namespace OOP___Inheritance_part_1_homework
{
    public class Teacher : Person
    {
        public DateTime DateOfStartWorking { get; set; }
        public DateTime DateOfEndWorking { get; set; }
        public int RestDays { get; set; }
        public string Branch { get; set; }
        public string Level { get; set; }
    }
}
