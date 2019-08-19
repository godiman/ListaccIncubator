using System;
namespace WebAPI.Data.Model
{
    public class Address
    {
        public int id {get; set;}
        public User user {get; set;}
        public string Country {get; set;}
        public string State {get; set;}
        public string sortCode {get; set;}
        public string street {get; set;}
    }
}