using System;
using WebAPI.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Data.Model;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        private readonly DataContext readContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public ValuesController(DataContext context, 
        UserManager<User> userManager, SignInManager<User> signInManager )
        {
           _userManager = userManager;
           _signInManager = signInManager;
            readContext = context;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(User user)
        {
            if (user == null)
           {
               return BadRequest("Fields should not be null");
           }
           if (ModelState.IsValid)
           {
              await _userManager.CreateAsync(user);
           }
           return Ok("User was creates");
        }

       
       /*  // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           var users = readContext.users;
           return Ok(users);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           var user1 = readContext.users.Where(o => o.id == id).FirstOrDefault();
           return Ok(user1);
        }

        [HttpGet("GetUserByGender/{gender}")]
        public IActionResult GetUserByGender(string gender)
        {
           var user1 = readContext.users.Where(a => a.gender == gender).ToList();
           return Ok(user1);
        }

         [HttpPost("LogIn")]
      

        // POST api/values
        [HttpPost("AddSomebody")]
       
        
        // PUT api/values/5
        [HttpPut("modifyRecord/{id}")]
       

        // DELETE api/values/5
        [HttpDelete("DeleteByID/{id}")]
        public IActionResult DeleteByID(int id)
        {
           var del = readContext.users.Where(c => c.id == id).FirstOrDefault();
           readContext.Remove(del);
           readContext.SaveChanges();
           return NoContent();
        }

         [HttpDelete("DeleteByName/{name}")]
        public void DeleteByName(string name)
        {
           var delName = readContext.users.Where(c => c.lastName == name).FirstOrDefault();
           readContext.Remove(delName);
           readContext.SaveChanges();
        }*/

    }
}
