using System.ComponentModel.DataAnnotations;
using System;
namespace DatinApp.webAPI.Data.Models
{
    public class Address
    {
        public int id {get; set;}
        public User user {get; set;}
        public int userId {get; set;}
        [Required]
        public string country {get; set;}
        [Required]
        public string state {get; set;}
        [Required]
        public string city {get; set;}
         public string street {get; set;}
    }
}