using Microsoft.EntityFrameworkCore;
using PeopleApi.Data;
using PeopleApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleApi.Services
{
    public class PessoaService
    {
        private readonly PessoaContexto _contexto;
        public PessoaService(PessoaContexto pessoaContexto)
        {
            _contexto = pessoaContexto;
        }

        public async Task<List<Pessoa>> ObterTodos()
        {
            var pessoas = await _contexto.Pessoas.ToListAsync();
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

        public async Task<Pessoa> Remover(int id)
        {
            Pessoa objetoEditado = await _contexto.Pessoas.FindAsync(id);

            objetoEditado.Ativo = false;
            _contexto.Update(objetoEditado);
            await _contexto.SaveChangesAsync();

            return objetoEditado;
        }

        public async Task Atualizar(Pessoa pessoa)
        {
            bool pessoaExiste = await _contexto.Pessoas.AnyAsync(x => x.Id == pessoa.Id);

            if (!pessoaExiste) throw new KeyNotFoundException("Pessoa não encontrada!");

            try
            {
                _contexto.Update(pessoa);
                await _contexto.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException erro)
            {
                throw new DbUpdateConcurrencyException(erro.Message);
            }
        }
    }
}
