using System;
using System.ComponentModel.DataAnnotations;

namespace PeopleApi.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
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
