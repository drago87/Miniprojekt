using System.ComponentModel.DataAnnotations;

namespace Miniprojekt.Models.ImgText
{
    public class Image
    {
        [Key]
        public int Id { get; protected set; }

        public string Url { get; protected set; }

        public string Desciption { get; protected set; }

        public Image() { }

        public Image(string url, string description)
        {
            this.Url = url;
            this.Desciption = description;
        }

        public void SetUrl(string url)
        {
            this.Url = url;
        }

        public void SetDescription(string description)
        {
            this.Desciption = description;
        }
    }
}