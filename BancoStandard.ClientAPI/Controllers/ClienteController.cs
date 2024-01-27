using BancoStandard.CadastroAPI.Data.ValueObjects;
using BancoStandard.CadastroAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoStandard.CadastroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _repository;
        public ClienteController(IClienteRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteVO>>> FindAld()
        {
            var products = await _repository.FindAll();
            if (products == null) return NotFound();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product.Id <= 0) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ClienteVO>> Create(ClienteVO vo)
        {
            if (vo == null) return BadRequest();
            var cliente = await _repository.Create(vo);
            return Ok(cliente);
        }

        [HttpPut]
        public async Task<ActionResult<ClienteVO>> Update(ClienteVO vo)
        {
            if (vo == null) return BadRequest();
            var cliente = await _repository.Update(vo);
            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
           
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
