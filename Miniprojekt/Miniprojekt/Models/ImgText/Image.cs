using System.ComponentModel.DataAnnotations;

namespace Miniprojekt.Models.ImgText
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Url { get; set; }

        [Required]
        public string SwedishWord { get; set; }

        [Required]
        public string EnglishWord { get; set; }

        public Image() { }

        public Image(string url, string swe, string eng)
        {
            this.Url = url;
            this.SwedishWord = swe;
            this.EnglishWord = eng;
        }

        public void SetUrl(string url)
        {
            this.Url = url;
        }

        public void SetSwedishWord(string swe)
        {
            this.SwedishWord = swe;
        }

        public void SetEnlighsWord(string eng)
        {
            this.EnglishWord = eng;
        }
    }
}