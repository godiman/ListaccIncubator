using System;
namespace DatinApp.webAPI.Data.Models
{
    public class Message
    {
        public int id {get; set;}
        public User user {get; set;}
        public User senderId {get; set;}
        public User recieverId {get; set;}
        public string content {get; set;}
        public DateTime timeSent {get; set;}
        public DateTime delivery {get; set;}
    }
}