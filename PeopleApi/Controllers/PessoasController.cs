using Microsoft.AspNetCore.Mvc;
using PeopleApi.Models;
using PeopleApi.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleApi.Controllers
{
    [Route("api/pessoas")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoasController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public async Task<List<Pessoa>> Get()
        {
            return await _pessoaRepository.ObterTodos();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _pessoaRepository.ObterPorId(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Pessoa pessoa)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _pessoaRepository.Adicionar(pessoa);

            return Ok(pessoa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid) return  BadRequest(ModelState);

            await _pessoaRepository.Atualizar(pessoa);

            return Ok(pessoa);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _pessoaRepository.Remover(id);

            return Ok();
        }
    }
}
