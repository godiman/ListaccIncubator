using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DatinApp.webAPI.Data;
using DatinApp.webAPI.Data.IRepo;
using DatinApp.webAPI.Data.Models;
using DatinApp.webAPI.Data.Repositories;
using DatinApp.webAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DatinApp.webAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly DataContext _context;
        private readonly IService _service;
        private readonly IUser _userFromRepo;
        private readonly IConfiguration _config;
        public AuthController(IUser userFromRepo, IConfiguration config, IService service, DataContext context)
        {
            _userFromRepo = userFromRepo;
            _config = config;
            _service = service;
            _context = context;
            //_UserManager = UserManager;
            
           
        }
         [HttpPost("Register")]
             public IActionResult Register(User model)
         {
             if (ModelState.IsValid)
             {
                  _userFromRepo.AddUser(model);
             
             }
            return Ok("Successfully save");
         }


         [HttpPost("Login")]
        public IActionResult Login(SignInDTO signIn)
        {
             IActionResult response = Unauthorized();
            var user = _userFromRepo.UserName(signIn);
           // var result =  _service.PasswordChecker(user, signIn);
            if (user != null)
            {
               
                var tokenString = _service.generateToken(user);
                response = Ok(new { token = tokenString,
                user
                
                });
               
            }
 
            return response;
        }

       
    }
}
