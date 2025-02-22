﻿using CarCharging.API.Models;
using CarCharging.Core.Model;
using CarCharging.Core.Service;
using CarCharging.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarCharging.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StopController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
       public  StopController(IUserService userService,IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
           foreach(User user in _userService.GetAll())
            {
                if(id==user.Id)
                    return user;
            }
            return null;
        }

        // POST api/<UserController>
        [HttpPost]
        public User Post([FromBody] UserPostModel user)
        {
           return _userService.AddUser(_mapper.Map<User>(user));
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public User Put(int id, [FromBody] User user)
        {
            return _userService.UpdateUser(id, user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
