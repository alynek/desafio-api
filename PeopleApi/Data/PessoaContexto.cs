using Microsoft.EntityFrameworkCore;
using PeopleApi.Models;

namespace PeopleApi.Data
{
    public class PessoaContexto : DbContext
    {
        public PessoaContexto(DbContextOptions<PessoaContexto> options) : base(options){}

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<FaixaEtaria> FaixasEtarias { get; set; }
    }
}
