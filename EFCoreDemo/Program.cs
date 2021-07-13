using System;
using System.Collections.Generic;

namespace EFCoreDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ManyToManyDbContext())
            {
                ctx.Database.EnsureCreated();

                var comedy = new Genre() { GenreId = 1, GnereName = "Comedy" };
                var action = new Genre() { GenreId = 2, GnereName = "Action" };
                var horror = new Genre() { GenreId = 3, GnereName = "Horror" };
                var drama = new Genre() { GenreId = 4, GnereName = "Drama" };

                ctx.AddRange(
                    new Movie() { MovieId = 1, Name = "Shaw Shank Redemption", Genres = new List<Genre>() { action, comedy } },
                            new Movie { MovieId = 2, Name = "Insidious", Genres = new List<Genre>() { horror } },
                            new Movie { MovieId = 3, Name = "Forest Gump", Genres = new List<Genre>() { drama } });
            }
            Console.WriteLine("Welcome to the EF Core 5.0 Demo!!!");
            Console.ReadLine();

        }
    }

    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public List <Genre> Genres { get; set; }
    }

    public class Genre
    {
        public int GenreId { get; set; }
        public string GnereName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
