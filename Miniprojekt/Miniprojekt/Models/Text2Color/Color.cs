using System.ComponentModel.DataAnnotations;

namespace Miniprojekt.Models.Text2Color
{
    public class Color
    {
        [Key]
        public string Name { get; set; }

        [Required]
        public string HexValue { get; set; }

        public Color() { }

        public Color(string name, string hexvalue)
        {
            this.Name = name;
            this.HexValue = hexvalue;
        }
    }
}
