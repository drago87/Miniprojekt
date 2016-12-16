using System.Data.Entity;

namespace Miniprojekt.DataAccess
{
    using Models.SentenceBuilding;

    public class SBContext : DbContext
    {
        public SBContext() : base("DefaultConnection") { }

        public DbSet<Sentence> Sentences { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("SentenceBuilder");
        }
    }
}