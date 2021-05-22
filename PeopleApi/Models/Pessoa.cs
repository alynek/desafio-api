using System;
using System.ComponentModel.DataAnnotations;

namespace PeopleApi.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataNascimento { get; set; }

        public bool Ativo { get; set; }

        public int FaixaEtariaId { get; set; }

        public FaixaEtaria FaixaEtaria { get; set; }


        public int MostrarIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - this.DataNascimento.Year;
        }
    }
}
