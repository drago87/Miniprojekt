namespace Miniprojekt.Migrations.Uppgift2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Miniprojekt.Models.Uppgift2Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Miniprojekt.DataAccess.DataAccessLayerUppgift2>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\Uppgift2";
        }

        protected override void Seed(Miniprojekt.DataAccess.DataAccessLayerUppgift2 context)
        {
            context.uppgift2.AddOrUpdate(
                p => p.ID,
                new Uppgift2 { Mening = "Sa du något?" },
                new Uppgift2 { Mening = "Bra något nytt." },
                new Uppgift2 { Mening = "Det var en stor Groda!" });

            // Update-Database -ConfigurationTypeName Miniprojekt.Migrations.Uppgift2.Configuration

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
