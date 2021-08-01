using System;

namespace TPH
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TPH!");
        }                
    }

    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Teacher : Person
    {
        public DateTime HireDate { get; set; }

    }

    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
    }
}
