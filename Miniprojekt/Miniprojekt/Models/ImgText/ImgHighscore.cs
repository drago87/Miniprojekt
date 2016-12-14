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
        public string Username { get; protected set; }

        [Required]
        public int Score { get; protected set; }

        [Required]
        public DateTime Date { get; protected set; }

        public ImgHighscore() { }

        public ImgHighscore(string username, int score, DateTime date)
        {
            this.Username   = username;
            this.Score      = score;
            this.Date       = date;
        }
    }
}