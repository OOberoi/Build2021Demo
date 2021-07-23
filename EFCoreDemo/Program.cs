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

            var comedy = new Genre() { GnereName = "Comedy" };
            var action = new Genre() { GnereName = "Action" };
            var horror = new Genre() { GnereName = "Horror" };
            var drama = new Genre() { GnereName = "Drama" };

            ctx.AddRange(
                new Movie() { Name = "Shaw Shank Redemption", Genres = new List<Genre>() { action, comedy } },
                        new Movie { Name = "Insidious", Genres = new List<Genre>() { horror } },
                        new Movie { Name = "Forest Gump", Genres = new List<Genre>() { drama } },
                        new Movie { Name = "The Bucket List", Genres = new List<Genre>() { comedy } });
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
        public string GnereName { get; set; }        
        public List<Movie> Movies { get; set; }
    }
}
