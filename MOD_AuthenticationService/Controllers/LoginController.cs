using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_AuthenticationService.Models;
using MOD_AuthenticationService.Repositories;

namespace MOD_AuthenticationService.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _repository;
        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        [Route("Validate/{email}/{password}")]
        public Token Get(string email, string password)
        {
            if (_repository.UserLogin(email, password) != null)
            {
                User response = _repository.UserLogin(email, password);
                return new Token() { message = "User", token = response.UserId.ToString() };
            }
            else if (_repository.MentorLogin(email, password)!= null)
            {
                Mentor response = _repository.MentorLogin(email, password);
                return new Token() { message = "Mentor", token = response.MentorId.ToString()};
            }
            else if (email == "Coursera" && password == "admin")
            {
                return new Token() { message = "Admin", token = "Admin" };
            }
            else
            {
                return new Token() { message = "Invalid User/Mentor", token = "" };
            }
        }
        public string GetToken()
        {
            return "";
        }



    }
}
