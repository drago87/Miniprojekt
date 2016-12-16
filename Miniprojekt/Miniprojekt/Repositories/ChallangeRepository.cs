﻿using Miniprojekt.DataAccess;
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
        private QuestionContext db;


        public ChallangeRepository()
        {
            db = new QuestionContext();
        }

        /*public ICollection<Question> GetAllQuestions
        {
            
            //return db.Questions.ToList();
        }*/

        public List<int> Get5QuestionIDFromCategory(string category)
        {
            Random rnd = new Random();
            var temp = db.Questions.Where(b=>b.Category == category).ToList();
            List<Question> ret = new List<Question>();
            
            int i = 0;
            int antal;
            if (temp.Count <= 4)
            {
                antal = temp.Count - 1;
            }
            else
            {
                antal = 4;
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
                            if (item.theQuestion == temp[temp1].theQuestion)
                            {
                                answer = true;
                            }
                        }
                        if (answer == true)
                        {
                            
                        }
                        else
                        {
                            ret.Add(temp[temp1].ID);
                            i += 1;
                        }
                        
                    }
                    catch
                    {

                    }
                }
                
            }

            return ret;
        }

        public List<int> Get15QuestionIDFromAllCategorys()
        {
            Random rnd = new Random();
            var temp = db.Questions.ToList();
            List<int> ret = new List<Question>();
            
            int i = 0;
            int antal;
            if (temp.Count <= 14)
            {
                antal = temp.Count - 1;
            }
            else
            {
                antal = 14;
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
                            if (item.theQuestion == temp[temp1].theQuestion)
                            {
                                answer = true;
                            }
                        }
                        if (answer == true)
                        {
                            
                        }
                        else
                        {
                            ret.Add(temp[temp1].ID);
                            i += 1;
                        }
                        
                    }
                    catch
                    {

                    }
                }
                
            }

            return ret;
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