using ApiChamado.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiChamado.Domain.Domain.Map
{
    class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("livro", "biblioteca");

            builder.HasKey(x => x.Id);


            builder.Property(x => x.Id)
               .HasColumnName("id_livro").IsRequired();

            builder.Property(f => f.Nome)
               .HasColumnName("nm_livro").IsRequired()
               .HasMaxLength(100);

            builder.Property(f => f.Descricao)
             .HasColumnName("ds_livro").IsRequired()
             .HasMaxLength(500);

            builder.Property(x => x.Status)
              .HasColumnName("st_livro").IsRequired()
              .HasMaxLength(10);

        }
    }
}
