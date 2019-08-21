using System.ComponentModel.DataAnnotations;
using System;
namespace WebAPI.Data.Model
{
    public class User
    {
        public int id{get; set; }
        [Required]
        public string lastName{get; set; }
        [Required]
        public string firstName{get; set; }
        [Required]
        public string email{get; set; }
        [Required]
        public string password{get; set; }
        [Required]
        public string userName{get; set; }
        [Required]
        public string gender{get; set; }
        [Required]
        public DateTime DateOfBirth{get; set; }
    }
}