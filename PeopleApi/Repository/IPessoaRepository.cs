using PeopleApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleApi.Repository
{
    public interface IPessoaRepository
    {
        Task<List<Pessoa>> ObterTodos();
        Task<Pessoa> ObterPorId(int id);
        Task Adicionar(Pessoa pessoa);
        Task<Pessoa> ObterPessoaViaQuery(int id);
        Task<Pessoa> Remover(int id);
        Task<Pessoa> Atualizar(Pessoa pessoa, int Id);
    }
}