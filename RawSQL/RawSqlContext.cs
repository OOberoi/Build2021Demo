﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace RawSQL
{
    public class RawSqlContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public RawSqlContext(DbContextOptions<RawSqlContext> options) :base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {          
            optionsBuilder.UseSqlServer("server=DESKTOP-9AB4882; database=Company; trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Department>()
                .HasKey(d => d.DepartmentId)
                .IsClustered();

            modelBuilder.Entity<Department>()
                .Property<int>("DepartmentId");

            modelBuilder.Entity<Department>()
                .Property<string>("Name");
                

            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmployeeId)
                .IsClustered();

            modelBuilder.Entity<Employee>()
                .Property<int>("EmployeeId");

            modelBuilder.Entity<Employee>()
                .Property("FirstName");

            modelBuilder.Entity<Employee>()
                .Property("LastName");



            base.OnModelCreating(modelBuilder);
        }
    }
}
