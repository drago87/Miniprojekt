namespace Miniprojekt.Migrations.ImgText
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ImgText.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(nullable: false),
                        SwedishWord = c.String(nullable: false),
                        EnglishWord = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ImgText.ImgHighscores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Score = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("ImgText.ImgHighscores");
            DropTable("ImgText.Images");
        }
    }
}
