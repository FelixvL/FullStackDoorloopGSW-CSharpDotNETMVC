using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaarDeDatabaseContext
{
    public class DeDatabaseContext : DbContext
    {
        public DeDatabaseContext(DbContextOptions options) : base (options){ }
        public DbSet<Huis> huizen { get; set; }
    }
}
