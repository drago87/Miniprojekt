namespace Miniprojekt.Migrations.Challange
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initzial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Question.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        theQuestion = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "Question.Answers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        answer = c.String(nullable: false),
                        trueFlase = c.Boolean(nullable: false),
                        Question_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("Question.Questions", t => t.Question_ID)
                .Index(t => t.Question_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Question.Answers", "Question_ID", "Question.Questions");
            DropIndex("Question.Answers", new[] { "Question_ID" });
            DropTable("Question.Answers");
            DropTable("Question.Questions");
        }
    }
}
