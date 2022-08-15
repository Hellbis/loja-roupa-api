using LojaRoupaApi.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LojaRoupaApi.Infra
{
    public class LojaContext : DbContext
    {
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Roupa> Roupas { get; set; }
        public DbSet<RoupaVariacao> RoupasVariacoes { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roupa>()
                .HasMany(s => s.RoupasVariacao)
                .WithOne(s => s.Roupa);
            modelBuilder.Entity<Cor>()
                .HasMany(s => s.RoupasVariacoes)
                .WithOne(s => s.Cor);
            modelBuilder.Entity<Tipo>()
                .HasMany(s => s.Roupas)
                .WithOne(s => s.Tipo);
            modelBuilder.Entity<RoupaVariacao>()
                .HasOne(s => s.Estoque)
                .WithOne(s => s.RoupaVariacao)
                .HasForeignKey<Estoque>(s => s.IdRoupaVariacao);
            modelBuilder.Entity<Venda>()
                .HasOne(s => s.RoupaVariacao)
                .WithMany(s => s.Vendas);

            base.OnModelCreating(modelBuilder);
        }
    }
}
