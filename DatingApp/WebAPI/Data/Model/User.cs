using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Data.Model
{
    public class User: IdentityUser
    {
        public string lastName{get; set; }
        [Required]
        public string firstName{get; set; }
        [Required]
        public string gender{get; set; }
        [Required]
        public DateTime DateOfBirth{get; set; }
    }
}