using System.Collections.Generic;
using System.Threading.Tasks;
using DatinApp.webAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatinApp.webAPI.Data.IRepo
{
    public interface IUser
    {
         void AddUser(User user);
         List <User> AllUsers();
         List <User> getUsersByGender(User gender);
        List<User> UserByName(User user);
        User UserName( SignInDTO userInput);

    }
}