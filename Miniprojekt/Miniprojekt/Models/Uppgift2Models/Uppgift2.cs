using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models.Uppgift2Models
{
    public class Uppgift2
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Mening { get; set; }
        
        public Nullable<int> Orginal_ID { get; set; }
    }
}