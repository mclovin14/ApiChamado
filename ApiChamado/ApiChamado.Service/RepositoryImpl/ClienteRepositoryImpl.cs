using ApiChamado.Domain.Domain;
using ApiChamado.Domain.Model;
using ApiChamado.Service.Repository;

namespace ApiChamado.Service.RepositoryImpl
{
    public class ClienteRepositoryImpl : BaseRepositoryImpl<Cliente>, IClienteRepository
    {
        public ClienteRepositoryImpl(ApiChamadoContext dbcontext):base(dbcontext)
        {
        }
    }
}
