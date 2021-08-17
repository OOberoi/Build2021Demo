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
}
