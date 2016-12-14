﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Miniprojekt.Models.Text2Color
{
    public class Highscore
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Username { get; protected set; }
        [Required]
        public int Points { get; protected set; }
        public DateTime Time { get; protected set; }

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
