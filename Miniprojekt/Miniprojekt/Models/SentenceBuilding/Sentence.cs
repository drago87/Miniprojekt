using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models.SentenceBuilding
{
    public class Sentence
    {
        [Key]
        public int ID { get; set; }
        [Required, DisplayName("Tillgängliga Ord")]
        public string mySentence { get; set; }
    }
}