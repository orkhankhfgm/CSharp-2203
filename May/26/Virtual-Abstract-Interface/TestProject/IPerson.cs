using System;

namespace TestProject
{
    interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Patronymc { get; set; }
        DateTime DateOfBirth { get; set; } //DOB Dob
    }
}
