﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models.Challange
{
    public class Question
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string theQuestion { get; set; }

        [ForeignKey("answers")]
        [Required]
        public string Answer { get; set; }
        [Required]
        public string Category { get; set; }

        public virtual List<Answers> answers { get; set; }
        
    }
}