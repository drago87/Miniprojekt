namespace Miniprojekt.Migrations.Text2Color
{
    using Models.Text2Color;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Miniprojekt.DataAccess.Text2ColorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Text2Color";
        }

        protected override void Seed(Miniprojekt.DataAccess.Text2ColorContext context)
        {
            context.Colors.AddOrUpdate(
                p => p.Name,
                new Color("Green", "#00FF00"),
                new Color("Red", "#FF0000"),
                new Color("Blue", "#0000FF")
            );
        }
    }
}
