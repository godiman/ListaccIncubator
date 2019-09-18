using System.Threading.Tasks;
using DatinApp.webAPI.Data.Models;

namespace DatinApp.webAPI.Data.IRepo
{
    public interface IService
    {
         string generateToken(User user);
         Task<bool> PasswordChecker(User user, SignInDTO password);
    }
}