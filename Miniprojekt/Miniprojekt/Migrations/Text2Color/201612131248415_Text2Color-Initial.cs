namespace Miniprojekt.Migrations.Text2Color
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Text2ColorInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Text2Color.Colors",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        HexValue = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "Text2Color.Highscores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Points = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("Text2Color.Highscores");
            DropTable("Text2Color.Colors");
        }
    }
}
