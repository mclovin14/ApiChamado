using ApiChamado.Domain.Model;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChamado.Service.Repository
{
    public interface IBaseRepository<T> where T: BaseEntity
    {
        IQueryable<T> GetAll();

        Task<T> GetById(int id);

        Task Create(T entity);

        Task Update(int id, T entity);

        Task Delete(int id);
    }
}
