using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogBackEnd.Models;
using BlogBackEnd.Models.DTO;
using BlogBackEnd.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogBackEnd.Controllers
{
    [ApiController]
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
        [HttpGet("GetAllUsers")]
        public IEnumerable<UserModel> GetAllUsers(){
            return _data.GetAllUsers();
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDTO User){
            return _data.Login(User);
        }
        [HttpPost("DeleteUser/{userToDelete}")]
        public bool DeleteUser(string userToDelete){
            return _data.DeleteUser(userToDelete);
        }
        [HttpPost("UpdateUser")]
        public bool UpdateUser(int id,string username)
        {
            return _data.UpdateUser(id,username);
        }
    }
}