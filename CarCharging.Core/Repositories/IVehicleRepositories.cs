using CarCharging.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Repositories
{
    public interface IVehicleRepositories
    {
        List<Vehicle> GetAll();
        Vehicle GetVehicle(int id);
        Vehicle AddVehicle(Vehicle vehicle);
        Vehicle UpdateVehicle(int id, Vehicle vehicle);
        void DeleteVehicle(int id);
    }
}
