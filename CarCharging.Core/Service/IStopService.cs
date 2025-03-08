using CarCharging.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Service
{
    public interface IStopService
    {
        public List<Stop> GetAll();
        public Stop GetStop(int id);
        public void Deletestop(int id);
        public Stop AddStop(Stop stop);
        public Stop UpdateStop(int id, Stop stop);
    }
}
