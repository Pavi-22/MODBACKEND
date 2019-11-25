    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_UserService.Models;
using MOD_UserService.Repositories;

namespace MOD_UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        // GET: api/User
        [HttpGet]
        [Route("GetAllUser")]
        public List<User> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/User/5
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetUserById/{id}")]
        public User Get(int id)
        {
            return _repository.GetById(id);
        }
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetMentorBySkill/{id}")]
        public List<Mentor> Get(string id)
        {
            return _repository.SearchMentor(id);
        }

        // POST: api/User
        [HttpPost]
        [Route("AddUser")]
        public IActionResult Post([FromBody] User item)
        {
            _repository.AddUser(item);
            return Ok("Record Added");
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        [Route("UpdateUser/{email}/{password}")]
        public void Put(string email,string password)
        {
            _repository.UpdateUserPassword(email,password);
        }

        [HttpPut("{id}")]
        [Route("BlockUser/{id}")]
        public void Put(int id)
        {
            _repository.BlockUser(id);
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteUser/{id}")]
        public void Delete(int id)
        {
            _repository.DeleteUser(id);
        }
    }
}
