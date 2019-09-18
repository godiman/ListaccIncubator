using System.Threading.Tasks;
using DatinApp.webAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DatinApp.webAPI.Data
{
    public class Seed
    {
        private readonly DataContext _Context;
        public Seed(DataContext context)
        {
            _Context = context;
        }

           public async Task seedUser()
        {
            var userData = System.IO.File.ReadAllText("Data/FlatFile.Json");
            var Client = JsonConvert.DeserializeObject<User[]>(userData);
            //if (! (await _Context.users.CountAsync() > 0))
            {
                foreach (User use in Client)
                {
                    _Context.Add(use);
                }
                await _Context.SaveChangesAsync();
            }
             User user = new User{
                lastName = "Okah",
                firstName = "John",
                gender = "Male",
                email = "johnokah124@gmail.com",
                dateOfBirth = System.DateTime.Now,
                userName = "JohnOkah123",
                password = "password",
            };
            _Context.Add(user);
           await _Context.SaveChangesAsync();
        }
    }
}