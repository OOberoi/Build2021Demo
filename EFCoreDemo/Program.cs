using System;
using System.Collections.Generic;


namespace EFCoreDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the EF Core 5.0 Demo!!!");
            Console.ReadLine();

        }
    }

    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        //public List <Genre> Genres { get; set; }
    }

   
}
