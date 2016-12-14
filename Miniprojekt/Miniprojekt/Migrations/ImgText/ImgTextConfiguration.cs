namespace Miniprojekt.Migrations
{
    using Miniprojekt.Models.ImgText;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ImgTextConfiguration : DbMigrationsConfiguration<Miniprojekt.DataAccess.ImgTextContext>
    {
        public ImgTextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Miniprojekt.DataAccess.ImgTextContext context)
        {
            context.Images.AddOrUpdate(
                i => i.Id,
                new Image { Id = 1, Url = "car_bil.jpg", SwedishWord = "Bil", EnglishWord = "Car" },
                new Image { Id = 2, Url = "bicycle_cykel.jpg", SwedishWord = "Cykel", EnglishWord = "Bicycle" }
            );
        }
    }
}
