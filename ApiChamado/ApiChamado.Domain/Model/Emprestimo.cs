using System;

namespace ApiChamado.Domain.Model
{
    public class Emprestimo : BaseEntity
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataAluguel { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
