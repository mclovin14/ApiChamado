using ApiChamado.Domain.Fixed;

namespace ApiChamado.Domain.Model
{
    public class Livro : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Status Status { get; set; }
    }
}
