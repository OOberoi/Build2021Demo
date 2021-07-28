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

    public class Teacher : Person
    {
        public DateTime HireDate { get; set; }
    }

    public class Adminstrator : Person
    {
        public string DepartmentName { get; set; }
        public string HireDate { get; set; }
    }
}
