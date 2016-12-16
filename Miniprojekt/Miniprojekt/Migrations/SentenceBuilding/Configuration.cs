namespace Miniprojekt.Migrations.SentenceBuilding
{
    using Miniprojekt.Models.SentenceBuilding;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    //Update-Database -ConfigurationTypeName Miniprojekt.Migrations.SentenceBuilding.Configuration
    internal sealed class Configuration : DbMigrationsConfiguration<Miniprojekt.DataAccess.SBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\SentenceBuilding";
        }

        protected override void Seed(Miniprojekt.DataAccess.SBContext context)
        {


            context.Sentences.AddOrUpdate(
                p => p.mySentence,
                new Sentence { mySentence = "Teorierna om det mänskliga språkets ursprung är långt ifrån samstämmiga och till och med ganska kontroversiella." },
                new Sentence { mySentence = "Det finns en mångfald av teorier, men alltför lite data. " },
                new Sentence { mySentence = "Vissa huvudlinjer går dock att skönja. " },
                new Sentence { mySentence = "Alla mänskliga populationer idag talar fullvärdiga språk och har samma språkförmåga, alltså måste alla biologiska aspekter av vår språkförmåga ha funnits i vår senaste gemensamma förfader, som levde för 150 000–200 000 år sedan." },
                new Sentence { mySentence = "Språket kan vara äldre, men det kan inte vara yngre. " },
                new Sentence { mySentence = "Av fynd av verktyg har man dragit slutsatsen att språket har sett ungefär likadant ut i åtminstone fyrtio tusen år, även om de kan ha gjort det mycket längre än så, kanske till och med uppåt ett par miljoner år." },
                new Sentence { mySentence = "1940-talet var också den tid då jazz på allvar började uppskattas som mer än underhållning och klubbmusik. "},
                new Sentence { mySentence = "Vid den här tiden hade musikformen uppnått en hög grad av sofistikerat samspel, skiftande harmonik och rytmisk precision samtidigt som den hade skapat en lång rad framträdande solister, pianister, bandledare och sångerskor." },
                new Sentence { mySentence ="George Gershwin och Francis Poulenc hade tidigt insett att jazzen höll på att skapa ett nytt tonspråk och vävt in element därifrån i sina verk. Under 40-50-talen blev jazzen mer än någonsin samtidens musik, och det skedde inte minst i Europa, där jazzen inte sågs som \"race music\" eller enbart ett uttryck för svart mentalitet. "},
                new Sentence { mySentence = "Jazzen vann nu uppskattning från seriösa tonsättare, musikkritiker, författare, filmskapare och en bred vit publik som inte nödvändigtvis dansade utan lika gärna lyssnade till musiken. " },
                new Sentence { mySentence = "Samtidigt började europeiska jazzmusiker dyka upp, en utveckling som fick en kraftig skjuts av de amerikanska truppernas närvaro i Västeuropa från 1943; många av dessa soldater var svarta, och en del av dem tog tillfället att spela jazz på lediga stunder." }
                );
        }
    }
}







