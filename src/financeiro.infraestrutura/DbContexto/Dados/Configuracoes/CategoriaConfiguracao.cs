using financeiro.dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace financeiro.infraestrutura.Contexto.Dados.Configuracoes
{
    public class CategoriaConfiguracao : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c =>  c.CategoriaID );
            builder.Property(p => p.NomeCategoria)
                .HasColumnType("NVARCHAR(80)")
                .HasMaxLength(80)
                .IsRequired();
            builder.HasMany(p => p.SubCategorias)
                   .WithOne(p => p.Categoria);

            builder.HasIndex(i => i.NomeCategoria).HasName("IDX_Nome");
        }
    }
}
