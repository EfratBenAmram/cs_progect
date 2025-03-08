using AutoMapper;
using CarCharging.Core.DTOs;
using CarCharging.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCharging.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
            CreateMap<Stop, StopDto>().ReverseMap();
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
        }
    }
}
