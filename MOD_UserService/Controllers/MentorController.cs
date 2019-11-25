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
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Mentor
        [HttpGet]
        [Route("GetAllMentor")]
        public List<Mentor> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Mentor/5
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetMentorById/{id}")]
        public Mentor Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Mentor
        [HttpPost]
        [Route("AddMentor")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _repository.AddMentor(item);
            return Ok("Record Added");
        }

        // PUT: api/Mentor/5
        [HttpPut("{id}")]
        [Route("UpdateMentor/{email}/{password}")]
        public void Put(string email,string password)
        {
            _repository.UpdateMentorPassword(email,password);
        }
        [HttpPut("{id}")]
        [Route("BlockUser/{id}")]
        public void put(int Id)
        {
            _repository.BlockMentor(Id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteMentor/{id}")]
        public void Delete(int id)
        {
            _repository.DeleteMentor(id);
        }
    }
}
