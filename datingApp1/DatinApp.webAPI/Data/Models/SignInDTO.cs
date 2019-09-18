using System.ComponentModel.DataAnnotations;

namespace DatinApp.webAPI.Data.Models
{
    public class SignInDTO
    {
        [Required(ErrorMessage = "Username should not be empty", AllowEmptyStrings= false)]
        public string UserName{get; set;}
        [Required (ErrorMessage = "Password should not be empty")]
        [DataType(DataType.Password)]
        public string password{get; set;}
    }
}