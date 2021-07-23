using System;

namespace TPT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
    }
}
