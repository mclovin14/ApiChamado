using ApiChamado.Domain.Model;
using System.Threading.Tasks;

namespace ApiChamado.Service.Repository
{
    public interface ILivroRepository : IBaseRepository<Livro>
    {
        Task AlugarDevolverLivro(int id);
    }
}
