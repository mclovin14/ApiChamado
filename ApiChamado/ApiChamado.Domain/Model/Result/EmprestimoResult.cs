using System;
using System.Collections.Generic;
using System.Text;

namespace ApiChamado.Domain.Model.Result
{
    public class EmprestimoResult
    {
        public int? Id { get; set; }
        public int? ClienteId { get; set; }
        public string? ClienteNome { get; set; }
        public int? LivroId { get; set; }
        public string? LivroNome { get; set; }
        public string? DataAluguel { get; set; }
        public string? DataEntrega { get; set; }

        public EmprestimoResult(Emprestimo emprestimo)
        {
            Id = emprestimo?.Id;
            ClienteId = emprestimo?.ClienteId;
            ClienteNome = emprestimo?.Cliente?.Nome;
            LivroId = emprestimo?.LivroId;
            LivroNome = emprestimo?.Livro?.Nome;
            DataAluguel = emprestimo?.DataAluguel.ToString("dd/MM/yyyy");
            DataEntrega = emprestimo?.DataEntrega.ToString("dd/MM/yyyy");

        }
        public static explicit operator EmprestimoResult (Emprestimo emprestimo)
        {
            return new EmprestimoResult(emprestimo);
        }

    }
}
