using CarCharging.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Service
{
    public interface IVehicleService
    {
        public List<Vehicle> GetAll();
        public Vehicle GetVehicle(int id);
        public Vehicle AddVehicle(Vehicle vehicle);
        public Vehicle UpdateVehicle(int id, Vehicle vehicle);
        public void DeleteVehicle(int id);
    }
}
