using CarCharging.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Service
{
    public interface IChargeStationService
    {
        public List<ChargeStation> GetAll();
        public ChargeStation GetChargeStation(int id);
        public void DeleteChargeStation(int id);
        ChargeStation AddChargeStation(ChargeStation ChargeStation);
        ChargeStation UpdateChargeStation(int id, ChargeStation ChargeStation);
    }
}
