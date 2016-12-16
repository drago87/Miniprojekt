namespace Miniprojekt.Migrations.ImgText
{
    using Miniprojekt.Models.ImgText;
    using System.Data.Entity.Migrations;

    internal sealed class ImgTextConfiguration : DbMigrationsConfiguration<Miniprojekt.DataAccess.ImgTextContext>
    {
        public ImgTextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\ImgText";
        }

        protected override void Seed(Miniprojekt.DataAccess.ImgTextContext context)
        {
            //Update-Database -ConfigurationTypeName Miniprojekt.Migrations.ImgText.Configuration
            context.Images.AddOrUpdate(
                i => i.Id,
                new Image { Id = 1, Url = "car_bil.jpg", SwedishWord = "Bil", EnglishWord = "Car" },
                new Image { Id = 2, Url = "bicycle_cykel.jpg", SwedishWord = "Cykel", EnglishWord = "Bicycle" }
            );
        }
    }
}
