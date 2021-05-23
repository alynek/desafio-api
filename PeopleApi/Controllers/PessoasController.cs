using Microsoft.AspNetCore.Mvc;
using PeopleApi.Models;
using PeopleApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleApi.Controllers
{
    [Route("api/pessoas")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly PessoaService _pessoaService;
        public PessoasController(PessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public async Task<List<Pessoa>> Get()
        {
            return await _pessoaService.ObterTodos();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _pessoaService.ObterPorId(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Pessoa pessoa)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _pessoaService.Adicionar(pessoa);

            return Ok(pessoa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid) return  BadRequest(ModelState);

            await _pessoaService.Atualizar(pessoa);

            return Ok(pessoa);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _pessoaService.Remover(id);

            return Ok(pessoa);
        }
    }
}
