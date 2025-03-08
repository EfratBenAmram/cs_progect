using CarCharging.Core.Model;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CarCharging.Core.Repositories
{
    public interface IStopRepositories
    {
        List<Stop> GetAll();
        Stop GetStop(int id);
        Stop AddStop(Stop stop);
        Stop UpdateStop(int id, Stop stop);
        void DeleteStop(int id);
    }
}
