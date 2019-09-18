using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatinApp.webAPI.Data.IRepo;
using DatinApp.webAPI.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatinApp.webAPI.Data.Repositories
{
    [Authorize]
    public class UserRepository : IUser
    {
        
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
    
        public void AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChangesAsync();
                  
        }
        
        public List<User> AllUsers()
        {
            var allUsers = _context.Users.ToList();
            return allUsers;           
        }

        public List<User> getUsersByGender(User gender)
        {
            var usersByGender = _context.Users.
            Where(g => g.gender == gender.gender).ToList();
            return usersByGender;
        }

        public List<User> UserByName(User user)
        {
           var users = _context.Users.Where(u => u.firstName==user.firstName ||
            u.lastName==user.lastName).ToList();
           return users;   
        }
       
        public User UserName(SignInDTO userLogIn)
        {
            var userName = _context.Users.Where(u => u.userName.CompareTo(userLogIn.UserName)==0 &&
             u.password.CompareTo(userLogIn.password)==0).FirstOrDefault();
            return  userName;
        }
    }
}