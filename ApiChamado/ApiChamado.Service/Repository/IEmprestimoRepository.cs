using ApiChamado.Domain.Model;
using ApiChamado.Domain.Model.Result;
using System.Threading.Tasks;

namespace ApiChamado.Service.Repository
{
    public interface IEmprestimoRepository : IBaseRepository<Emprestimo>
    {
        Task InserirEmprestimo(Emprestimo emprestimo);
        Task<EmprestimoResult> GetByIdAgrupado(int id);
        Task EncerrarEmprestimo(int id);
    }
}
