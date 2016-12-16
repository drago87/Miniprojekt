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
                    option = new List<Answer> { new Answer{ answer = "Red", trueFlase = false }, new Answer{ answer = "Blue", trueFlase = true },new Answer{ answer = "Green", trueFlase = false } },
                    Category = "Nature"
                },
                new Question
                {
                    theQuestion = "What is 2 x 2?",
                    option = new List<Answer> { new Answer { answer = "2", trueFlase = false }, new Answer { answer = "0", trueFlase = false }, new Answer { answer = "4", trueFlase = true } },
                    Category = "Math"
                },
                new Question
                {
                    theQuestion = "Is there gravity in space?",
                    option = new List<Answer> { new Answer { answer = "yes", trueFlase = true }, new Answer { answer = "no", trueFlase = false }, new Answer { answer = "we dont know", trueFlase = false } },
                    Category = "Physics"
                },
                new Question
                {
                    theQuestion = "What color is blood in the veins?",
                    option = new List<Answer> { new Answer { answer = "Red", trueFlase = true }, new Answer { answer = "Blue", trueFlase = false }, new Answer { answer = "Green", trueFlase = false } },
                    Category = "Biology"
                },
                new Question
                {
                    theQuestion = "What is edible?",
                    option = new List<Answer> { new Answer { answer = "Mercury", trueFlase = false }, new Answer { answer = "Seaweed", trueFlase = true }, new Answer { answer = "Pizza", trueFlase = true } },
                    Category = "Biology"
                }

                );
        }
    }
}
