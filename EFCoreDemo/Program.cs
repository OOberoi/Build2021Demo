using System;
using System.Collections.Generic;

namespace EFCoreDemo
{
    public class Program
    {
        static void Main(string[] args)
        
        {
            using var ctx = new ManyToManyDbContext();
            ctx.Database.EnsureCreated();

            var comedy = new Genre() { GenreName = "Comedy" };
            var action = new Genre() { GenreName = "Action" };
            var horror = new Genre() { GenreName = "Horror" };
            var drama = new Genre() { GenreName = "Drama" };
            var comedy1 = new Genre() { GenreName = "Comedy" };

            ctx.AddRange(
                new Movie() { Name = "Shaw Shank Redemption", Genres = new List<Genre>() { action, comedy } },
                        new Movie { Name = "Insidious", Genres = new List<Genre>() { horror } },
                        new Movie { Name = "Forest Gump", Genres = new List<Genre>() { drama } },
                        new Movie { Name = "The Bucket List", Genres = new List<Genre>() { comedy } },
                        new Movie { Name = "City Slickers", Genres = new List<Genre>() { comedy1 } });
            ctx.SaveChanges();
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
        public string GenreName { get; set; }        
        public List<Movie> Movies { get; set; }
    }
}
