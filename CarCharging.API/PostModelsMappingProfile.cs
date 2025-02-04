using AutoMapper;
using CarCharging.API.Models;
using CarCharging.Core.Model;

namespace CarCharging.API
{
    public class PostModelsMappingProfile:Profile
    {
        public PostModelsMappingProfile()
        {
            CreateMap<UserPostModel, User>();
        }

    }
}
