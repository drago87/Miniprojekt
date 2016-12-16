namespace Miniprojekt.Migrations.Challange
{
    using Miniprojekt.Models.Challange;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Miniprojekt.DataAccess.QuestionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Challange";
        }

        protected override void Seed(Miniprojekt.DataAccess.QuestionContext context)
        {


            context.Questions.AddOrUpdate(
                x => x.theQuestion,
                new Question
                {
                    theQuestion = "What color is the sky?",
                    option = new List<Answer> { new Answer{ AnswerString = "Red", TrueFalse = false }, new Answer{ AnswerString = "Blue", TrueFalse = true },new Answer{ AnswerString = "Green", TrueFalse = false } },
                    Category = "Nature"
                },
                new Question
                {
                    theQuestion = "What is 2 x 2?",
                    option = new List<Answer> { new Answer { AnswerString = "2", TrueFalse = false }, new Answer { AnswerString = "0", TrueFalse = false }, new Answer { AnswerString = "4", TrueFalse = true } },
                    Category = "Math"
                },
                new Question
                {
                    theQuestion = "Is there gravity in space?",
                    option = new List<Answer> { new Answer { AnswerString = "yes", TrueFalse = true }, new Answer { AnswerString = "no", TrueFalse = false }, new Answer { AnswerString = "we dont know", TrueFalse = false } },
                    Category = "Physics"
                },
                new Question
                {
                    theQuestion = "What color is blood in the veins?",
                    option = new List<Answer> { new Answer { AnswerString = "Red", TrueFalse = true }, new Answer { AnswerString = "Blue", TrueFalse = false }, new Answer { AnswerString = "Green", TrueFalse = false } },
                    Category = "Biology"
                },
                new Question
                {
                    theQuestion = "What is edible?",
                    option = new List<Answer> { new Answer { AnswerString = "Mercury", TrueFalse = false }, new Answer { AnswerString = "Seaweed", TrueFalse = true }, new Answer { AnswerString = "Pizza", TrueFalse = true } },
                    Category = "Biology"
                }

                );
        }
    }
}
