using Miniprojekt.DataAccess;
using Miniprojekt.Models.ImgText;

namespace Miniprojekt.Repository
{
    public class ImgTextRepository
    {
        public ImgTextContext db = new ImgTextContext();

        public bool CompareTextImg(string text, Image img)
        {
            if (img.SwedishWord == text)
                return true;
            else if (img.EnglishWord == text)
                return true;
            else
                return false;
        }
    }
}