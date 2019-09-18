using System;
namespace DatinApp.webAPI.Data.Models
{
    public class Photo
    {
        public int id {get; set;}
        public User user {get; set;}
        public int userId {get; set;}
        public  DateTime time {get; set;}
        public bool isMain {get; set;}
        public string photo {get; set;}

    }
}