using System.Data.Entity;

namespace Miniprojekt.DataAccess
{
    using Miniprojekt.Models.Challange;

    public class QuestionContext : DbContext
    {
        public QuestionContext() : base("DefaultConnection") { }

        public DbSet<Question> Questions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("SentenceBuilder");
        }
    }
}