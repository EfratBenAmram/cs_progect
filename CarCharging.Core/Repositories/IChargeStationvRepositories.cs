using CarCharging.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Repositories
{
    public interface IChargeStationRepositories
    {
        List<ChargeStation> GetAll();
        ChargeStation GetChargeStation(int id);
        ChargeStation AddChargeStation(ChargeStation ChargeStation);
        ChargeStation UpdateChargeStation(int id, ChargeStation ChargeStation);
        void DeleteChargeStation(int id);
    }
}
