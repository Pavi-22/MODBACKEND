using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_TrainingService.Models;
using MOD_TrainingService.Repositories;

namespace MOD_TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingsRepository _repository;
        public TrainingController(ITrainingsRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Training
        [HttpGet]
        [Route("GetTrainings")]
        public List<Training> Get()
        {
            return _repository.GetTrainings();
        }
        [HttpGet("{id}", Name = "GetByUser")]
        [Route("GetTrainingByUser/{id}")]
        public List<Training> GetByUser(int id)
        {
            return _repository.GetTrainingByUserId(id);
        }
        [HttpGet("{id}", Name = "GetByMentor")]
        [Route("GetTrainingByMentor/{id}")]
        public List<Training> GetByMentor(int id)
        {
            return _repository.GetTrainingByMentorId(id);
        }

        // GET: api/Training/5
        /*[HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST: api/Training
        [HttpPost]
        [Route("AddTrainings")]
        public IActionResult Post([FromBody] Training item)
        {
            _repository.AddTrainings(item);
            return Ok("Record Added");
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("EditTrainings/{id}")]
        public void Put(Training item)
        {
            _repository.EditTraining(item);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
