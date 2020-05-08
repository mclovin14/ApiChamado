using ApiChamado.Domain.Domain;
using ApiChamado.Domain.Model;
using ApiChamado.Service.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChamado.Service.RepositoryImpl
{
    public abstract class BaseRepositoryImpl<T> : IBaseRepository<T> where T : BaseEntity
    {
        public readonly ApiChamadoContext _dbContext;

        public BaseRepositoryImpl(ApiChamadoContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsNoTracking();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>()
                 .AsNoTracking()
                 .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Update(int id, T entity)
        {
            var entityDB = await GetById(id);
            entityDB = entity;
            _dbContext.Set<T>().Update(entityDB);
            await _dbContext.SaveChangesAsync();
        }
    }
}
