using System.Data.Entity;

namespace Miniprojekt.DataAccess
{
    using Models.Text2Color;

    public class Text2ColorContext : DbContext
    {
        public Text2ColorContext() : base("DefaultConnection") { }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Highscore> Highscores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Text2Color");
        } 
    }
}