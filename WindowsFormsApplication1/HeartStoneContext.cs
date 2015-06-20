using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataLayer
{
    public class HearthStoneContext : DbContext
    {

        public HearthStoneContext()
            : base("HearthStoneContext")
        {
        }

        public DbSet<Basic> Basics { get; set; }
        public DbSet<Debug> Debugs { get; set; }

        public DbSet<Credit> Credits { get; set; }

        public DbSet<Classic> Classics { get; set; }

        public DbSet<Mission> Missions { get; set; }

        public DbSet<Reward> Rewards { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<System> Systems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
