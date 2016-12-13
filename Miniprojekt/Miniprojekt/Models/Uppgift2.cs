using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models
{
    public class Uppgift2
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Mening { get; set; }

    }
}