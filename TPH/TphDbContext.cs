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
    public class TphDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
    }
}
