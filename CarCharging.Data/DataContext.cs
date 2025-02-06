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
        public DbSet<Stop> Stops { get; set; }
        public DbSet<ChargeStation> ChargeStations { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

    }
}
