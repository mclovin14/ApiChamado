using System.Threading.Tasks;
using ApiChamado.Domain.Domain;
using ApiChamado.Domain.Fixed;
using ApiChamado.Domain.Model;
using ApiChamado.Service.Repository;
using Microsoft.EntityFrameworkCore;

namespace ApiChamado.Service.RepositoryImpl
{
    public class LivroRespositoryImpl : BaseRepositoryImpl<Livro>, ILivroRepository
    {
        public LivroRespositoryImpl(ApiChamadoContext dbContext) : base(dbContext)
        {
       
        }

        public async Task AlugarDevolverLivro(int id)
        {
            var livro = await _dbContext.Livros.SingleOrDefaultAsync(x => x.Id == id);
            if (livro.Status == Status.Disponível)
                livro.Status = Status.Alugado;
            else
                livro.Status = Status.Disponível;
            await Update(id, livro);
        }
    }
}
