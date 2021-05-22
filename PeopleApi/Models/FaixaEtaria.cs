using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopleApi.Models
{
    public class FaixaEtaria
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Faixa { get; private set; } 
        public List<Pessoa> Pessoas { get; set; }
    }
}
