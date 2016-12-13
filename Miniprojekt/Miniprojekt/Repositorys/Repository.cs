using Miniprojekt.DataAccess;
using Miniprojekt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Miniprojekt.Repositorys
{
    public class Repository
    {
        private DataAccessLayerUppgift2 db;

        public Repository()
        {
            db = new DataAccessLayerUppgift2();
        }

        public ICollection<Uppgift2> GetAllSentences()
        {
            return db.uppgift2.ToList();
        }

        public ICollection<Uppgift2> ReturnAllSentencesWithAsterisk()
        {
            List<Uppgift2> temp = db.uppgift2.ToList();

            foreach (var item in temp)
            {
                item.Mening.Replace('-', '*');
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

        public string GetRandomSentence()
        {
            Random rnd = new Random();
            var temp = db.uppgift2.ToList();
            return temp[rnd.Next(temp.Count)].Mening;
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