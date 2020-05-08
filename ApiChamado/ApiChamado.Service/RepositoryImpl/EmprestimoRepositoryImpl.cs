using ApiChamado.Domain.Domain;
using ApiChamado.Domain.Model;
using ApiChamado.Domain.Model.Result;
using ApiChamado.Service.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiChamado.Service.RepositoryImpl
{
    public class EmprestimoRepositoryImpl : BaseRepositoryImpl<Emprestimo>, IEmprestimoRepository
    {
        private readonly ILivroRepository _livroRepository;
        public EmprestimoRepositoryImpl(ApiChamadoContext dbContext, ILivroRepository livroRepository) : base(dbContext)
        {
            _livroRepository = livroRepository;
        }

        public async Task EncerrarEmprestimo(int id)
        {
            var emprestimo = await _dbContext.Emprestimos.SingleOrDefaultAsync(x => x.Id == id);
            await _livroRepository.AlugarDevolverLivro(emprestimo.LivroId);
            await Delete(id);
        }

        public async Task<EmprestimoResult> GetByIdAgrupado(int id)
        {
            var query = await _dbContext.Emprestimos
                .Include(x => x.Cliente)
                .Include(x => x.Livro)
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);
            return (EmprestimoResult)query;
        }

        public async Task InserirEmprestimo(Emprestimo emprestimo)
        {
            await Create(emprestimo);
            await _livroRepository.AlugarDevolverLivro(emprestimo.LivroId);
        }
    }
}
