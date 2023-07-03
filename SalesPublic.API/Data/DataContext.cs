using Microsoft.EntityFrameworkCore;
using SalesPublic.Shared.Entities;

namespace SalesPublic.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Contries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x=>x.Name).IsUnique();
        }
    }
}
