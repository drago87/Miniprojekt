using Miniprojekt.DataAccess;
using Miniprojekt.Models.Challange;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Miniprojekt.Repositories
{
    public class ChallangeRepository
    {
        private QuestionContext db = new QuestionContext();

        public ICollection<Question> GetAllQuestions()
        {
            return db.Questions.ToList();
        }

        public List<Question> GetRandomQuestions()
        {
            return db.Questions.OrderBy(q => Guid.NewGuid()).Take(15).ToList();
        }


        public List<Question> GetRandomQuestionsFromCategory(string category)
        {
            return db.Questions.Where(b => b.Category == category).OrderBy(q => Guid.NewGuid()).Take(5).ToList();
        }


        public void EditInDB(Question obje)
        {
            db.Entry(obje).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void AddToDB(Question obje) 
        {
            db.Questions.Add(obje);
            db.SaveChanges();
        }

        public void RemoveFromDB(Question obje)
        {
            db.Questions.Remove(obje);
            db.SaveChanges();
        }

    }
}