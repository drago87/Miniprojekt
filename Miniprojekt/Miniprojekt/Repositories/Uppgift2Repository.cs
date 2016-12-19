using Miniprojekt.DataAccess;
using Miniprojekt.Models.Uppgift2Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Miniprojekt.Repositories
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
            Uppgift2 test;
            int i = 0;
            foreach (var item in old)
            {
                test = new Uppgift2();
                string ny = item.Mening.Replace("-", "*").Replace(",", "*").Replace(".", "*").Replace("!", "*").Replace("?", "*");
                test.ID = i;
                test.Mening = ny;
                test.Orginal_ID = item.ID;
                temp.Add(test);
                i += 1;
            }
            
            return temp;
        }

        public int CalculatePoints(List<Uppgift2> list)
        {
            
            var temp = db.uppgift2.ToList();
            int Points = 0;
            foreach (var item in list)
            {
                var temp2 = temp.Where(b => b.Mening == item.Mening && b.ID == item.Orginal_ID);
                if (temp2.Count() >0)
                {
                    Points += 1;
                }
            }
            return Points;
        }

        public ICollection<Uppgift2> GetRandomSentence()
        {
            /*Random rnd = new Random();
            var temp = db.uppgift2.ToList();
            List<Uppgift2> ret = new List<Uppgift2>();
            
            int i = 0;
            int antal;
            if (temp.Count <= 9)
            {
                antal = temp.Count - 1;
            }
            else
            {
                antal = 9;
            }
            while (i <= antal)
            {
                int check = i;
                while (check == i)
                {
                    var temp1 = rnd.Next(temp.Count);
                    try
                    {
                        bool answer = false;
                        foreach (var item in ret)
                        {
                            if (item.Mening == temp[temp1].Mening)
                            {
                                answer = true;
                            }
                        }
                        if (answer == true)
                        {
                            
                        }
                        else
                        {
                            ret.Add(temp[temp1]);
                            i += 1;
                        }
                        
                    }
                    catch{}
                }
                
            }
            */
            var ret = db.uppgift2.OrderBy(q => Guid.NewGuid()).Take(10).ToList();

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