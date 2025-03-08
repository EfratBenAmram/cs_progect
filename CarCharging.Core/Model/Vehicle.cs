using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int AvgChargeTime { get; set; }
        public List<Stop> stops { get; set; }
    }
}
    