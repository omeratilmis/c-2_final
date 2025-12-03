using System;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Create a new student
                var student = new Student
                {
                    FirstName = "Michael",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(2000, 8, 20),
                    Email = "michael.smith@example.com",
                    Department = "Computer Engineering",
                    CurrentSemester = 3,
                    GPA = 3.92,
                    StudentNumber = "2023001",
                    RegistrationDate = DateTime.Now,
                    IsFullTime = true
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.WriteLine($"Student ID: {student.StudentId}");
                Console.WriteLine($"Name: {student.FirstName} {student.LastName}");
                Console.WriteLine($"Department: {student.Department}");
                Console.WriteLine($"Student Number: {student.StudentNumber}");
                Console.WriteLine($"Current Semester: {student.CurrentSemester}");
                Console.WriteLine($"GPA: {student.GPA}");
                Console.WriteLine($"Full Time: {student.IsFullTime}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}