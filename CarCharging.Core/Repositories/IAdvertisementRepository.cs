using CarCharging.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Repositories
{
    public interface IAdvertisementRepository
    {
        List<Advertisement> GetAdvertisements();
        Advertisement AddAdvertisement(Advertisement adv);
        Advertisement UpdateAdvertisement(int id, Advertisement adv);
        void DeleteAdvertisement(int id);
    }
}
