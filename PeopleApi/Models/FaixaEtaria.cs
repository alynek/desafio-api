using System.Collections.Generic;

namespace PeopleApi.Models
{
    public class FaixaEtaria
    {
        public int Id { get; set; }
        public string Faixa { get; private set; } 
        public List<Pessoa> Pessoas { get; set; }
    }
}
