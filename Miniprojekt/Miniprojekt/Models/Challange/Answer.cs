﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models.Challange
{
    public class Answer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string answer { get; set; }

        [Required]
        public bool trueFlase { get; set; }
    }
}