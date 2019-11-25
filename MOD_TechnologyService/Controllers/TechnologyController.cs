using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_TechnologyService.Models;
using MOD_TechnologyService.Repositories;

namespace MOD_TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyRepository _repository;
        public TechnologyController(ITechnologyRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Technology
        [HttpGet]
        [Route("GetAllSkills")]
        public List<Technology> Get()
        {
            return _repository.GetSkills();
        }

       /* // GET: api/Technology/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
*/
        // POST: api/Technology
        [HttpPost]
        [Route("AddSkills")]
        public IActionResult Post(Technology item)
        {
            _repository.AddSkills(item);
            return Ok();
        }

        // PUT: api/Technology/5
        [HttpPut("{id}")]
        [Route("UpdateSkills/{id}")]
        public IActionResult Put(Technology item)
        {
            _repository.EditSkills(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeleteSkills/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteSkills(id);
            return Ok();
        }
    }
}
