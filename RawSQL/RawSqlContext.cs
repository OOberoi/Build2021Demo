using System;
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
            modelBuilder.Entity<Department>().HasKey();
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Employee>().HasKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
