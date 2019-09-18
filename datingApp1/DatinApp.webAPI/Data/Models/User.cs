using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DatinApp.webAPI.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        //[Required]
        public string lastName { get; set; }
        //[Required]
        public string firstName { get; set; }
        
         [Required(ErrorMessage = "Username should not be empty", AllowEmptyStrings= false)]
        public string userName { get; set; }
        //[Required]
        //[EmailAddress]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
       // [Required]
        public string gender { get; set; }
        //[Required]
        public DateTime dateOfBirth { get; set; }
        ICollection <Message> messages { get; set; }
        ICollection <Like> likes{get; set;}
        ICollection <Address> Addresses {get; set;}
        ICollection<Photo> Photos{get; set;}
         ICollection<Video> Videos {get; set;}
    }
}