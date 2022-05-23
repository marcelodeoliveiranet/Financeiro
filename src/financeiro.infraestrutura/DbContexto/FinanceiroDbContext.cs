using financeiro.dominio;
using Microsoft.EntityFrameworkCore;

namespace financeiro.infraestrutura.Contexto
{
    public class FinanceiroDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=Financeiro;User ID=sa;Password=Jetro@302522");
        }

        protected virtual void OnModelCreatuing(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FinanceiroDbContext).Assembly);
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
    }
}
