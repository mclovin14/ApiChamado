using ApiChamado.Domain.Domain.Map;
using ApiChamado.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiChamado.Domain.Domain
{
    public class ApiChamadoContext : DbContext
    {
        public ApiChamadoContext(DbContextOptions<ApiChamadoContext> options) : base (options) { }

        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChamadoMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EmprestimoMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
