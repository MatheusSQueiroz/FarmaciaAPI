using FarmaciaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FarmaciaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("tb_produtos");
        }

        public DbSet<Produto> Produtos { get; set; } = null!;
    }
}
