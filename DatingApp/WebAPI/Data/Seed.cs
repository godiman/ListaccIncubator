using System;
using System.Threading.Tasks;
using WebAPI.Data.Model;
using System.Linq;
using Newtonsoft.Json;
namespace WebAPI.Data
{
    public class Seed
    {
      /*   public readonly DataContext _Context ;
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
            /* User user = new User{
                lastName = "Okah",
                firstName = "John",
                gender = "Male",
                email = "johnokah124@gmail.com",
                DateOfBirth = System.DateTime.Now,
                userName = "JohnOkah123",
                password = "password",
            };
            _Context.Add(user);
           await _Context.SaveChangesAsync();
        }*/
    }
}