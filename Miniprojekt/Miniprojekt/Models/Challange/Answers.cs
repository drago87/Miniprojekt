using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models.Challange
{
    public class Answers
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Answer { get; set; }
        [Required]
        public bool isRight { get; set; }
    }
}