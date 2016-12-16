using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models.Challange
{
    public class Question
    {
        [Key]
        public int ID { get; set; }

        public string theQuestion { get; set; }

        public Dictionary<string, bool> Answers { get; set; }

        public string Category { get; set; }
        
    }
}