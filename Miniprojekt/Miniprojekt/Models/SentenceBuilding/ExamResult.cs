using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models.SentenceBuilding
{
    public class ExamResult
    {

        public ICollection<string> MisspelledAndExcessWords { get; set; }

        public ICollection<string> ForgottenWords { get; set; }

        public int Points { get; set; }

        public ExamResult()
        {
            MisspelledAndExcessWords = new List<string>();

            ForgottenWords = new List<string>();

            Points = 0;
        }

    }
}