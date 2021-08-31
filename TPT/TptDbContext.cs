using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TPT
{
    public class TptDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Adminstrator> Administrators { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9AB4882; database=demo.TPT; trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property<int>("ID");
            modelBuilder.Entity<Person>()
                .Property<string>("FirstName");
            modelBuilder.Entity<Person>()
                .Property<string>("LastName");
            modelBuilder.Entity<Person>()
                .Property<DateTime>("EnrollmentDate");
            modelBuilder.Entity<Person>()
                .Property<string>("HireDate");
            modelBuilder.Entity<Person>()
                .Property<string>("DepartmentName");
            modelBuilder.Entity<Person>()
                .Property<DateTime>("Teacher_HireDate");
            base.OnModelCreating(modelBuilder);

        }
    }
}