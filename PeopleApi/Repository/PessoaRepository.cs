using Microsoft.EntityFrameworkCore;
using PeopleApi.Data;
using PeopleApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleApi.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly PessoaContexto _contexto;
        public PessoaRepository(PessoaContexto pessoaContexto)
        {
            _contexto = pessoaContexto;
        }

        public async Task<List<Pessoa>> ObterTodos()
        {
            var pessoas = await _contexto.Pessoas.Where(x => x.Ativo == true).ToListAsync();
            return pessoas;
        }

        public async Task<Pessoa> ObterPorId(int id)
        {
            var pessoa = await _contexto.Pessoas.FirstOrDefaultAsync(x => x.Id == id);

            return pessoa;
        }

        public async Task Adicionar(Pessoa pessoa)
        {
            _contexto.Add(pessoa);
            await _contexto.SaveChangesAsync();
        }

        public async Task<Pessoa> ObterPessoaViaQuery(int id)
        {
            ADODb ado = new ADODb();

            var query = $@"select * from Pessoas where Id = {id}";

            return await ado.ExecutaQuery<Pessoa>(query);
        }

        public async Task<Pessoa> Remover(int id)
        {
            Pessoa pessoa = await ObterPessoaViaQuery(id);

            pessoa.Ativo = false;
            await Atualizar(pessoa, id);

            return pessoa;
        }

        public async Task<Pessoa> Atualizar(Pessoa pessoa, int id)
        {
            ADODb ado = new ADODb();

            var query = $@"update Pessoas set 
            Nome = '{pessoa.Nome}', DataNascimento = '{pessoa.DataNascimento}', Ativo = '{pessoa.Ativo}'
            where Id = {id};";

            await ado.ExecutaQuery<Pessoa>(query);

            var pessoaAtualizada = await ObterPessoaViaQuery(id);
            return pessoaAtualizada;
        }
    }
}
