using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.data
{
    public class SabelDbContext : DbContext
    {
        public SabelDbContext(DbContextOptions<SabelDbContext> options) : base(options) { }

        public DbSet<Organisation> Organisations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organisation>(entity =>
            {
                entity.ToTable("Organisation");
            });
        }
    }
}
