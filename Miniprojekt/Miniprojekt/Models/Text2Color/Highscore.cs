using System;
using System.ComponentModel.DataAnnotations;

namespace Miniprojekt.Models.Text2Color
{
    public class Highscore
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public int Points { get; set; }
        public DateTime Time { get; set; } 

        public Highscore() { }

        public Highscore(string username, int points, DateTime time)
        {
            this.Username = username;
            this.Points = points;
            this.Time = time;
        }

        public void SetTime(DateTime time)
        {
            this.Time = time;
        }
    }
}
