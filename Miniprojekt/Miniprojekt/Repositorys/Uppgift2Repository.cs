using Miniprojekt.DataAccess;
using Miniprojekt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Miniprojekt.Repositorys
{
    public class Uppgift2Repository
    {
        private DataAccessLayerUppgift2 db;

        public Uppgift2Repository()
        {
            db = new DataAccessLayerUppgift2();
        }

        public ICollection<Uppgift2> GetAllSentences()
        {
            return db.uppgift2.ToList();
        }

        public ICollection<Uppgift2> ReturnAllSentencesWithAsterisk(List<Uppgift2> old)
        {
            List<Uppgift2> temp = new List<Uppgift2>();
            Uppgift2 test = new Uppgift2();
            foreach (var item in old)
            {
                string ny = item.Mening.Replace("-", "*").Replace(",", "*").Replace(".", "*").Replace("!", "*").Replace("?", "*");
                test.Mening = ny;
                temp.Add(test);
            }
            
            return temp;
        }

        public int isright(List<Uppgift2> list)
        {
            
            var temp = db.uppgift2;
            foreach (var item in list)
            {
                temp.Where(b => b.Mening == item.Mening);
            }
            return temp.Count();
        }

        public ICollection<Uppgift2> GetRandomSentence()
        {
            Random rnd = new Random();
            var temp = db.uppgift2.ToList();
            List<Uppgift2> ret = new List<Uppgift2>();
            ret.Add(temp[rnd.Next(temp.Count)]);
            return ReturnAllSentencesWithAsterisk(ret);
        }

        public void EditInDB(Uppgift2 obje)
        {
            db.Entry(obje).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void AddToDB(Uppgift2 obje)
        {
            db.uppgift2.Add(obje);
            db.SaveChanges();
        }

        public void RemoveFromDB(Uppgift2 obje)
        {
            db.uppgift2.Remove(obje);
            db.SaveChanges();
        }
    }
}