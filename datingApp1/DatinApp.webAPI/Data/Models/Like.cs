
using System;
namespace DatinApp.webAPI.Data.Models
{
    public class Like
    {
        public int id {get; set;}
        public  User user {get; set;}
        public User likerId {get; set;}
        public User likeeId {get; set;}
        public DateTime time {get; set;}

    }
}