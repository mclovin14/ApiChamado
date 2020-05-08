using ApiChamado.Domain.Domain;
using ApiChamado.Domain.Model;
using ApiChamado.Service.Repository;
using System.Collections.Generic;
using System.Linq;


namespace ApiChamado.Service.RepositoryImpl
{
    public class ChamadoRepositoryImpl : IChamadoRepository
    {
        private readonly ApiChamadoContext context;


        public ChamadoRepositoryImpl(ApiChamadoContext context)
        {
            this.context = context;
        }

        public  List<Chamado> FindAll()
        {
            return context.Chamados.ToList();
        }

        public void Insert(Chamado chamado)
        {
            context.Chamados.Add(chamado);
            context.SaveChanges();

        }
    }
}
