using System.Linq;
using System.Threading.Tasks;
using ApiChamado.Domain.Model;
using ApiChamado.Service.Repository;

using Microsoft.AspNetCore.Mvc;

namespace ApiChamado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _repository;

        public ClienteController(IClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var chamados = _repository.GetAll();
            var teste = chamados.ToList();
            return Ok(teste);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            await _repository.Create(cliente);
            return Ok(GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _repository.GetById(id);
            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return Ok(GetAll());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update (int id, Cliente cliente)
        {
            await _repository.Update(id, cliente);
            return Ok(GetAll());
        }    
    }
}