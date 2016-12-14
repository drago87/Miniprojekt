namespace Miniprojekt.Migrations.Text2Color
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoMigrationActuallyNeeded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Text2Color.Highscores", "Username", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("Text2Color.Highscores", "Username", c => c.String());
        }
    }
}
