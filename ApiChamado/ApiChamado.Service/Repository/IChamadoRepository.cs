using ApiChamado.Domain.Model;
using System.Collections.Generic;


namespace ApiChamado.Service.Repository
{
    public interface IChamadoRepository
    {
        void Insert(Chamado chamado);

        List<Chamado> FindAll();
    }
}
