using Microsoft.AspNetCore.Mvc;
using PeopleApi.Data;
using PeopleApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleApi.Controllers
{
    [Route("api/pessoas")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly PessoaContexto _pessoaContexto;
        public PessoasController(PessoaContexto pessoaContexto)
        {
            _pessoaContexto = pessoaContexto;
        }

        [HttpGet]
        public List<Pessoa> Get()
        {
            var pessoas =  _pessoaContexto.
        }

        [HttpGet("{id}")]
        public Pessoa Get(int id)
        {
            var pessoa =  _pessoaContexto.Pessoas.Find(id);
            return pessoa;
        }

        [HttpPost]
        public void Post(Pessoa pessoa)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pessoa pessoa)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
