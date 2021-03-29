using Portfolio.Models;
using System.Data.Entity;

namespace Portfolio.Data
{
    public class PortfolioDBContext :DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(t => t.TechnologiesUsed)
                .WithMany(t => t.Projects)
                .Map(m =>
                {
                    m.ToTable("ProjectTechnologies");
                    m.MapLeftKey("ProjectId");
                    m.MapRightKey("TechnologyId");
                });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Technology> Technologies { get; set; }
    }
}