using BancoStandard.CadastroAPI.Data.ValueObjects;
using BancoStandard.CadastroAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BancoStandard.CadastroAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClienteRepository _repository;
        public ClientController(IClienteRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteVO>>> FindAll()
        {
            var clients = await _repository.FindAll();
            if (clients == null) return NotFound();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FindById(long id)
        {
            var client = await _repository.FindById(id);
            if (client.Id <= 0) return NotFound();
            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult<ClienteVO>> Create([FromBody] ClienteVO vo)
        {
            if (vo == null) return BadRequest();
            var client = await _repository.Create(vo);
            return Ok(client);
        }

        [HttpPut]
        public async Task<ActionResult<ClienteVO>> Update([FromBody] ClienteVO vo)
        {
            if (vo == null) return BadRequest();
            var client = await _repository.Update(vo);
            return Ok(client);
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
