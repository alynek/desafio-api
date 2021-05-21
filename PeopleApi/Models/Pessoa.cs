using System;

namespace PeopleApi.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }

        public int MostrarIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - this.DataNascimento.Year;
        }
    }
}
