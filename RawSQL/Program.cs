using System;

namespace RawSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello RAW SQL!");
        }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }
    }
}
