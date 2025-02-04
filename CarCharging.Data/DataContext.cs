using CarCharging.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Page> Pages { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

    }
}
