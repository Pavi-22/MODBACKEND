using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_PaymentService.Models;
using MOD_PaymentService.Repositories;

namespace MOD_PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _repository;
        public PaymentController(IPaymentRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Payment
        [HttpGet]
        [Route("GetAllPayment")]
        public List<Payment> Get()
        {
            return _repository.GetAllPayment();
        }

        // GET: api/Payment/5
        //[HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Payment
        [HttpPost]
        [Route("AddPayment")]
        public IActionResult Post([FromBody] Payment item)
        {
            _repository.AddPayment(item);
            return Ok("Record Added");
        }

        // PUT: api/Payment/5
        [HttpPut("{id}")]
        [Route("UpdatePayment/{id}")]
        public void Put(Payment item)
        {
            _repository.UpdatePayment(item);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("DeletePayment/{id}")]
        public void Delete(int id)
        {
            _repository.DeletePayment(id);
        }
    }
}
