using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int CurrentSemester { get; set; }
        public double GPA { get; set; }
        public string StudentNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsFullTime { get; set; }
    }
}