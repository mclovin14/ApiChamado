using ApiChamado.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiChamado.Domain.Domain.Map
{
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("emprestimo", "biblioteca");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
               .HasColumnName("id_emprestimo").IsRequired();

            builder.Property(x => x.ClienteId)
               .HasColumnName("id_cliente_emprestimo");

            builder.HasOne(x => x.Cliente)
               .WithMany()
               .HasForeignKey(x => x.ClienteId)
               .IsRequired();

            builder.Property(x => x.LivroId)
             .HasColumnName("id_livro_emprestimo");

            builder.HasOne(x => x.Livro)
              .WithMany()
              .HasForeignKey(x => x.LivroId)
              .IsRequired();

            builder.Property(x => x.DataAluguel)
              .HasColumnName("dt_aluguel_emprestimo").IsRequired();

            builder.Property(x => x.DataEntrega)
          .HasColumnName("dt_entrega_emprestimo").IsRequired();
        }
    }
}
