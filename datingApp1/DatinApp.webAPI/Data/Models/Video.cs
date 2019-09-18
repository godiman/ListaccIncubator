using System; 
namespace DatinApp.webAPI.Data.Models
{
    public class Video
    {
        public int id {get; set;}
        public User user {get; set;}
        public int userId {get; set;}
        public DateTime time {get; set;}
        public string video {get; set;}
    }
}