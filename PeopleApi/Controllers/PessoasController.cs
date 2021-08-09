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
            var pessoa = await _pessoaRepository.ObterPorId(id);

            if(pessoa == null) return NotFound();

            return Ok(pessoa);
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

            var pessoaAtualizada = await _pessoaRepository.Atualizar(pessoa, id);

            return Ok(pessoaAtualizada);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pessoa = await _pessoaRepository.ObterPorId(id);

            if (pessoa == null) return NotFound();

            await _pessoaRepository.Remover(pessoa.Id);

            return NoContent();
        }
    }
}
