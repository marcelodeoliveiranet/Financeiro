using financeiro.dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace financeiro.infraestrutura.Contexto.Dados.Configuracoes
{
    public class SubCategoriaConfiguracao : IEntityTypeConfiguration<SubCategoria>
    {
        public void Configure(EntityTypeBuilder<SubCategoria> builder)
        {
            builder.ToTable("SubCategorias");
            builder.HasKey(c => new { c.CategoriaID, c.SubCategoriaID });
            builder.Property(p => p.NomeSubCategoria)
                .HasColumnType("NVACHAR(80)")
                .HasMaxLength(80)
                .IsRequired();

            builder.HasIndex(i => i.NomeSubCategoria).HasName("IDX_NomeSubCategoria");
        }
    }
}
