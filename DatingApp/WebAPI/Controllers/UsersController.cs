using System;
using WebAPI.Service;
using WebAPI.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Data.Model;



namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public string text1;
        private readonly DataContext readContext;

        public ValuesController(DataContext context)
        {
            readContext = context;
        }

       
        // GET api/values
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
        public IActionResult LogIn(User user)
        {
           var login = readContext.users.
           Where(i => i.userName.CompareTo(user.userName) == 0 && i.password.CompareTo(user.password) == 0).ToList();
           return Ok(login);
        }

        // POST api/values
        [HttpPost("AddSomebody")]
        public IActionResult AddSomebody( User user)
        {       
           if (user == null)
            {
                return BadRequest("Should not be empty");
            }
            else
            {
            readContext.Add(user);
            readContext.SaveChangesAsync();
            return Ok("Successful");
            }  
        }
        

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("DeleteByID/{id}")]
        public void DeleteByID(int id)
        {
           var del = readContext.users.Where(c => c.id == id).FirstOrDefault();
           readContext.Remove(del);
           readContext.SaveChanges();
        }

         [HttpDelete("DeleteByName/{name}")]
        public void DeleteByName(string name)
        {
           var delName = readContext.users.Where(c => c.lastName == name).FirstOrDefault();
           readContext.Remove(delName);
           readContext.SaveChanges();
        }

    }
}
