using Microsoft.EntityFrameworkCore;
using SaleSpy.Core.Models;

namespace SaleSpy.Data
{
    public class SaleSpyDbContext : DbContext
    {
        public DbSet<ArticleSale> ArticleSales { get; set; }

        public SaleSpyDbContext(DbContextOptions<SaleSpyDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleSale>().ToTable("ArticleSale");
        }
    }
}
