using Miniprojekt.DataAccess;
using Miniprojekt.Models.SentenceBuilding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniprojekt.Repositories
{
    public class SentenceBuilderRepository
    {
        SBContext Database = new SBContext();

        public List<Sentence> GetAllSentences()
        {
            return Database.Sentences.ToList();
        }

        public Sentence GetRandomSentence()
        {
            List<Sentence> sentences = Database.Sentences.ToList();
            Random rand = new Random();
            int random = rand.Next(sentences.Count);
            Sentence sent = sentences[random];
            List<string> temp = sent.mySentence.Split(' ').ToList();
            string sentence = "";
            int length = temp.Count;
            for (int i = 0; i < length; i++)
            {
                string word = temp[rand.Next(temp.Count)];
                sentence += " " + word;
                temp.Remove(word);
            }
            return new Sentence {mySentence = sentence };

        }

        public ExamResult Examine(string StudentAnswers, string rightAnswers)
        {
            return Exam.Evaluate(StudentAnswers.Split(' ').Where(x => x != "").ToList(), rightAnswers.Split(' ').Where(x => x != "").ToList());
        }

    }
}