using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miniprojekt.Models.Text2Color
{
    public class Highscore
    {
        public string Username { get; protected set; }
        public int Points { get; protected set; }
        public DateTime Time { get; protected set; }

        public Highscore() { }

        public Highscore(string username, int points, DateTime time)
        {
            this.Username = username;
            this.Points = points;
            this.Time = time;
        }
    }
}
