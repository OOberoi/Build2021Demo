using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TPT
{
    public class TptDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
       
    }
}
