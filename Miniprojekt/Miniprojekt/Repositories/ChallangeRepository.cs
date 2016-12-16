using Miniprojekt.Models.Challange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniprojekt.Repositories
{
    public class ChallangeRepository
    {
        private ChallangeContext db;


        public ChallangeRepository()
        {
            db = new ChallangeContext();
        }

        public ICollection<Question> GetAllQuestions
        {

        }
    }
}