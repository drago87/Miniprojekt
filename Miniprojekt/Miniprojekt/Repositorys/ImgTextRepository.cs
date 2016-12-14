using Miniprojekt.DataAccess;
using Miniprojekt.Models.ImgText;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Miniprojekt.Repository
{
    public class ImgTextRepository
    {
        public ImgTextContext db = new ImgTextContext();

        public bool CompareTextImg(string text, Image img)
        {
            if (img.SwedishWord.ToLower() == text.ToLower())
                return true;
            else if (img.EnglishWord.ToLower() == text.ToLower())
                return true;
            else
                return false;
        }

        public Image GetRandomImg()
        {
            Random rand = new Random();
            List<Image> tmp = db.Images.ToList();
            return tmp[rand.Next(tmp.Count())];
        }

        public Image GetImgById(int? id)
        {
            if (id == null)
                return null;
            return db.Images.Find(id);
        }
    }
}