using Bulkyweb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, name = "Chair", description = "test Chair" },
                new Category { Id = 2, name = "decoration", description = "Decoration item for homes" },
                new Category { Id = 3, name = "Art", description = "Art item for homes" }
                );
        }
    }
}
