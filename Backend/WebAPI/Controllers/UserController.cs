﻿using Data_Layer;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository _repo;
        public UserController(IRepository p_repo)
        {
            _repo = p_repo;
        }

        // GET: api/<UserController>
        [HttpGet("All")]
        public IActionResult GetAllUser()
        {
            return Ok(_repo.GetAllUsers());
        }

        // GET api/<UserController>/5
        [HttpGet("{p_id}")]
        public IActionResult GetUserById(int p_id)
        {
            return Ok(_repo.GetUserById(p_id));
        }

        // POST api/<UserController>
        [HttpPost("Add")]
        public IActionResult AddUser([FromBody] User value)
        {
            return Created("api/User/Add", _repo.AddUser(value));
        }

        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUserById(int id)
        {
            return Ok(_repo.DeleteUserById(id));
        }


        //UPDATE api/update-user-by-id/{id}
        [HttpPut("update-user-by-id/{id}")]
        public IActionResult UpdateUserById(int id, [FromBody] User user)
        {
            var updateUser = _repo.UpdateUserById(id, user);
            return Ok(updateUser);
        }


        //UPDATE api/update-user-by-username/{username}
        [HttpPut("update-user-by-username/{username}")]
        public IActionResult UpdateUserByUsername(string username, [FromBody] User user)
        {
            var updateUser = _repo.UpdateUserByUsername(username, user);
            return Ok(updateUser);
        }


        //UPDATE api/update-user-by-email/{email}
        [HttpPut("update-user-by-email/{email}")]
        public IActionResult UpdateUserByEmail(string email, [FromBody] User user)
        {
            var updateUser = _repo.UpdateUserByEmail(email, user);
            return Ok(updateUser);
        }
    }
}
