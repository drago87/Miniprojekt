using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Miniprojekt.Models.SentenceBuilding;

namespace Miniprojekt.Tests.Models
{
    [TestClass]
    public class ExamTest
    {
        [TestMethod]
        public void TestEvaluatePoints()
        {
            var test = "this is a test".Split(' ').ToList();

            var answer = "fuck this test".Split(' ').ToList();

            ExamResult res = Exam.Evaluate(test, answer);

            Assert.AreEqual(2, res.Points);
        }

        [TestMethod]
        public void TestEvaluateForgotten()
        {
            var test = "this is a test not anything else".Split(' ').ToList();

            var answer = "fuck this test".Split(' ').ToList();

            ExamResult res = Exam.Evaluate(test, answer);

            Assert.AreEqual(5, res.ForgottenWords.Count);
        }

        [TestMethod]
        public void TestEvaluateMisspelledAndExcess()
        {
            var test = "this is a test not anything else".Split(' ').ToList();

            var answer = "fuck tis test and everything".Split(' ').ToList();

            ExamResult res = Exam.Evaluate(test, answer);

            Assert.AreEqual(4, res.MisspelledAndExcessWords.Count);
        }

    }
}


//foreach (string word in Test.Split(' '))
//{
//    allWords.Add(word);
//}