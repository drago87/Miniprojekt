using Miniprojekt.DataAccess;
using Miniprojekt.Models;
using System;
using System.Collections.Generic;
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

        public void isright(List<Uppgift2> list)
        {
            
            var temp = db.uppgift2;
            foreach (var item in list)
            {
                temp.Where(b => b.Mening == item.Mening);
            }
            int antalRatt = temp.Count();
        }
    }
}