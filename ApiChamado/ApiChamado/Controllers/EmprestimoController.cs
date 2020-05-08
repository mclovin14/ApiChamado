using ApiChamado.Domain.Model;
using ApiChamado.Service.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiChamado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoRepository _repository;

        public EmprestimoController(IEmprestimoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var chamados = _repository.GetAll();
            return Ok(chamados);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]Emprestimo emprestimo)
        {
            await _repository.InserirEmprestimo(emprestimo);
            return Ok(GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _repository.GetByIdAgrupado(id);
            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.EncerrarEmprestimo(id);
            return Ok(GetAll());
        }

    }
}
