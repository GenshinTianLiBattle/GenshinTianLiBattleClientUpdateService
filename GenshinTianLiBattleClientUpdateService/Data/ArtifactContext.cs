using Microsoft.EntityFrameworkCore;
using GenshinTianLiBattleClientUpdateService.Models;

namespace GenshinTianLiBattleClientUpdateService.Data
{
    public class ArtifactContext : DbContext
    {
        public ArtifactContext(DbContextOptions<ArtifactContext> options)
            : base(options)
        {
        }

        public DbSet<Artifact> Artifacts { get; set; }
        public DbSet<Token> Tokens { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Artifact>().ToTable("Artifact");
            modelBuilder.Entity<Models.Token>().ToTable("Token");
        }
    }
}
