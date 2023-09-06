using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogBackEnd.Models.DTO;
using BlogBackEnd.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogBackEnd.Controllers
{
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _data;
        //create a constructor

        public UserController(UserService dataFromService) {
           _data = dataFromService;
        }

        //add a user
        [HttpPost("AddUsers")]
        public bool AddUser(CreateAccountDTO UserToAdd) {
            return _data.AddUser(UserToAdd);
        }
          // if the user already exists
          //if the user does not exist create an account
          //else throw an error
        
    }
}