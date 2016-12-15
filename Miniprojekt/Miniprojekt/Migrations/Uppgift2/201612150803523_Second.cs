namespace Miniprojekt.Migrations.Uppgift2
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Uppgift2.Uppgift2",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mening = c.String(nullable: false),
                        Orginal_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("Uppgift2.Uppgift2");
        }
    }
}
