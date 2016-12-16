using System;
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

        public string Category { get; set; }

        public List<Answer> option { get; set; }
        
    }
}