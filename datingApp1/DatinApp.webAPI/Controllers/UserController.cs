using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatinApp.webAPI.Data;
using DatinApp.webAPI.Data.IRepo;
using DatinApp.webAPI.Data.Models;
using DatinApp.webAPI.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatinApp.webAPI.Controllers
{
    //[AllowAnonymous]
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUser _userRepo;
        
        public UserController(IUser userRepo)
        {
            _userRepo = userRepo;
        }
       
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var AllUser = _userRepo.AllUsers();
            return Ok(AllUser);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        [HttpPost("getUsersByGender")]
        public IActionResult getUsersByGender(User gender)
        {
           var ByGender = _userRepo.getUsersByGender(gender);
            return Ok(ByGender );
        }

         [HttpPost("userByName")]
        public IActionResult userByName(User name)
        {
            return Ok(_userRepo.UserByName(name) );
        }

        [HttpPost("checkPassword")]
    

        [HttpPost("username")]
        public IActionResult username(SignInDTO signInDTO)
        {
            var findUser = _userRepo.UserName(signInDTO);
           // var authenticate =_userRepo.CheckPassword(validate,username);
           
            return Ok(findUser);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {   
        }
    }
}
