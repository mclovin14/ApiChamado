using System.Threading.Tasks;
using ApiChamado.Domain.Model;
using ApiChamado.Service.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiChamado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {
        private readonly ILivroRepository _repository;
        public LivroController(ILivroRepository repository)
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
        public async Task<IActionResult> Create([FromBody]Livro livro)
        {
            await _repository.Create(livro);
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
        public async Task<IActionResult> Update(int id, Livro livro)
        {
            await _repository.Update(id, livro);
            return Ok(GetAll());
        }
    }
}