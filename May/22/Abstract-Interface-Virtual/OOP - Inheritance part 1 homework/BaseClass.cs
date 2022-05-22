using System;

namespace OOP___Inheritance_part_1_homework
{
    public class BaseClass
    {
        public int Id { get; set; }
        public int RegUser { get; set; }
        public DateTime RegDate { get; set; }
        public int EditUser { get; set; }
        public DateTime EditDate { get; set; }
        public int DeleteUser { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
