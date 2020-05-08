namespace ApiChamado.Domain.Model
{
    public class Chamado
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Chamado() { }
    }
}
