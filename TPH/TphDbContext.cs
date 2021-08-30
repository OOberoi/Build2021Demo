using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TPH;
using static TPH.Program;

namespace TPH
{
    //https://entityframework.net/tph
    public class TphDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Teacher> Teachers { get; set; }    
        public DbSet<Student> Student { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9AB4882; database=demo.TPH; trusted_connection=true;");
            base.OnConfiguring(optionsBuilder); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property<string>("FirstName");
            modelBuilder.Entity<Person>()
               .Property<string>("LastName");
            modelBuilder.Entity<Person>()
                .Property<DateTime>("EnrollmentDate");
            modelBuilder.Entity<Person>()
                .Property<DateTime>("HireDate");
            base.OnModelCreating(modelBuilder);
        }
    }
}
