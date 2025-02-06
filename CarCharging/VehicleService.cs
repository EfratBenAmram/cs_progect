using CarCharging.Core.Model;
using CarCharging.Core.Repositories;
using CarCharging.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Service

{
    public class VehicleService:IVehicleService
     
    {
        private readonly Core.Repositories.IVehicle _userRepository;
        public VehicleService(Core.Repositories.IVehicle userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetAll()
        { 
         return _userRepository.GetUsers();
        }
        public User AddUser(User user)
        {
          return _userRepository.AddUser(user);
        }
        public User UpdateUser(int id, User user)
        {
            return _userRepository.UpdateUser(id, user);
        }
       public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}