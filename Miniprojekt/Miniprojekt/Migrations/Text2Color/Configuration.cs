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
            // Update-Database -ConfigurationTypeName Miniprojekt.Migrations.Text2Color.Configuration
            context.Colors.AddOrUpdate(
                p => p.Name,
                new Color("AliceBlue", "#F0F8FF"),
                new Color("AntiqueWhite", "#FAEBD7"),
                new Color("Aqua", "#00FFFF"),
                new Color("Aquamarine", "#7FFFD4"),
                new Color("Azure", "#F0FFFF"),
                new Color("Beige", "#F5F5DC"),
                new Color("Bisque", "#FFE4C4"),
                new Color("BlanchedAlmond", "#FFEBCD"),
                new Color("HoneyDew", "#F0FFF0"),
                new Color("MintCream", "#F5FFFA"),
                new Color("GhostWhite", "#F8F8FF"),
                new Color("LightGoldenRodYellow", "#FAFAD2"),
                new Color("LemonChiffon", "#FFFACD"),
                new Color("FloralWhite", "#FFFAF0"),
                new Color("Snow", "#FFFAFA"),
                new Color("LightYellow", "#FFFFE0"),
                new Color("Ivory", "#FFFFF0"),
                new Color("White", "#FFFFFF"),
                new Color("SlateGray", "##708090"),
                new Color("LightSlateGray", "#778899")
            );
        }
    }
}
