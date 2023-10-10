﻿using FarmaciaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FarmaciaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("tb_produtos");
            modelBuilder.Entity<Categoria>().ToTable("tb_categorias");

            _ = modelBuilder.Entity<Produto>()
               .HasOne(_ => _.Categoria)
               .WithMany(c => c.Produto)
               .HasForeignKey("CategoriaId")
               .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Produto> Produtos { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;


    }
}
