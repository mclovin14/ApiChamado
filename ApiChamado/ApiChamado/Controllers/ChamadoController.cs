using ApiChamado.Domain.Model;
using ApiChamado.Service.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiChamado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChamadoController : Controller
    {
        private readonly IChamadoRepository repository;

        public ChamadoController(IChamadoRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           var chamados =  repository.FindAll();
            return Ok(chamados);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Chamado chamado)
        { 
            repository.Insert(chamado);
            return Ok(GetAll());
        }
    }
}