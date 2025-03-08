using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Model
{
    public class ChargeStation
    {
        public int Id { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public Boolean IsQuick { get; set; }

        public Stop Stop { get; set; }
    }
}
