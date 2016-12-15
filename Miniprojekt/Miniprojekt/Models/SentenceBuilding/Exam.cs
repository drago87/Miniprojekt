using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models.SentenceBuilding
{
    public static class Exam
    {
        public static ExamResult Evaluate(ICollection<string> test, ICollection<string> answer)
        {

            ExamResult result = new ExamResult { ForgottenWords = test };

            foreach (string word in answer)
            {
                if (result.ForgottenWords.Contains(word))
                {
                    result.Points += 1;
                    result.ForgottenWords.Remove(word);
                }
                else
                    result.MisspelledAndExcessWords.Add(word);

            }
            return result;
        }
    }
}