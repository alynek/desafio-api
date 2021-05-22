using System.Collections.Generic;

namespace PeopleApi.Models
{
    public class FaixaEtaria
    {
        public int Id { get; set; }
        public string Faixa1 { get; private set; }
        public string Faixa2 { get; private set; }
        public string Faixa3 { get; private set; }
        public string Faixa4 { get; private set; }
        public string Faixa5 { get; private set; }
        public string Faixa6 { get; private set; }
        public string Faixa7 { get; private set; }
        public string Faixa8 { get; private set; }
        public string Faixa9 { get; private set; }
        public string Faixa10 { get; private set; }
        public string Faixa11 { get; private set; } 
        public string Faixa12 { get; private set; } 
        public string Faixa13 { get; private set; } 
        public List<Pessoa> Pessoas { get; set; }
    }
}
