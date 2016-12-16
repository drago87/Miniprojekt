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
                new Sentence { mySentence = "Teorierna om det m�nskliga spr�kets ursprung �r l�ngt ifr�n samst�mmiga och till och med ganska kontroversiella." },
                new Sentence { mySentence = "Det finns en m�ngfald av teorier, men alltf�r lite data. " },
                new Sentence { mySentence = "Vissa huvudlinjer g�r dock att sk�nja. " },
                new Sentence { mySentence = "Alla m�nskliga populationer idag talar fullv�rdiga spr�k och har samma spr�kf�rm�ga, allts� m�ste alla biologiska aspekter av v�r spr�kf�rm�ga ha funnits i v�r senaste gemensamma f�rfader, som levde f�r 150 000�200 000 �r sedan." },
                new Sentence { mySentence = "Spr�ket kan vara �ldre, men det kan inte vara yngre. " },
                new Sentence { mySentence = "Av fynd av verktyg har man dragit slutsatsen att spr�ket har sett ungef�r likadant ut i �tminstone fyrtio tusen �r, �ven om de kan ha gjort det mycket l�ngre �n s�, kanske till och med upp�t ett par miljoner �r." },
                new Sentence { mySentence = "1940-talet var ocks� den tid d� jazz p� allvar b�rjade uppskattas som mer �n underh�llning och klubbmusik. "},
                new Sentence { mySentence = "Vid den h�r tiden hade musikformen uppn�tt en h�g grad av sofistikerat samspel, skiftande harmonik och rytmisk precision samtidigt som den hade skapat en l�ng rad framtr�dande solister, pianister, bandledare och s�ngerskor." },
                new Sentence { mySentence ="George Gershwin och Francis Poulenc hade tidigt insett att jazzen h�ll p� att skapa ett nytt tonspr�k och v�vt in element d�rifr�n i sina verk. Under 40-50-talen blev jazzen mer �n n�gonsin samtidens musik, och det skedde inte minst i Europa, d�r jazzen inte s�gs som \"race music\" eller enbart ett uttryck f�r svart mentalitet. "},
                new Sentence { mySentence = "Jazzen vann nu uppskattning fr�n seri�sa tons�ttare, musikkritiker, f�rfattare, filmskapare och en bred vit publik som inte n�dv�ndigtvis dansade utan lika g�rna lyssnade till musiken. " },
                new Sentence { mySentence = "Samtidigt b�rjade europeiska jazzmusiker dyka upp, en utveckling som fick en kraftig skjuts av de amerikanska truppernas n�rvaro i V�steuropa fr�n 1943; m�nga av dessa soldater var svarta, och en del av dem tog tillf�llet att spela jazz p� lediga stunder." }
                );
        }
    }
}







