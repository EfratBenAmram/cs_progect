using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Model
{
    public enum Esize
    {
        EIGHTH = 1, 
        QUARTER = 2,
        HALF = 4,
        FULL = 8
    }
    public class Stop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; } //in minute
        public Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
        public ChargeStation chargeStation { get; set; }
        public int ChargeStationId { get; set; } // Foreign key property
    }
}
