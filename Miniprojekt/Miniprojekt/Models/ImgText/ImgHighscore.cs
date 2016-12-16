using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models.ImgText
{
    public class ImgHighscore
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public int Score { get; set; }
        
        public DateTime Time { get; set; }

        public ImgHighscore() { }

        public ImgHighscore(string username, int score, DateTime time)
        {
            this.Username   = username;
            this.Score      = score;
            this.Time       = time;
        }

        public void SetTime(DateTime time)
        {
            this.Time = time;
        }
    }
}