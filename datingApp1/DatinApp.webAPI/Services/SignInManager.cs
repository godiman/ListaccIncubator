using System.Threading.Tasks;
using DatinApp.webAPI.Data.Models;
using DatinApp.webAPI.Data;
using System.Linq;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using DatinApp.webAPI.Data.IRepo;

namespace DatinApp.webAPI.Services
{
    public class SignInManager: IService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;
        public SignInManager(DataContext context,IConfiguration config)
        {
            _context = context;
            _config = config;
        }
       
        public string generateToken(User user)
        {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.userName)
                    
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.Now.AddDays(30),
                    SigningCredentials = credentials

                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
        }

        public Task<bool> PasswordChecker(User user, SignInDTO model)
        {
         var check = _context.Users.Where(p => p.userName==user.userName && p.password == model.password).FirstOrDefault();
           return Task.FromResult<bool>(true);
        }
    }
}