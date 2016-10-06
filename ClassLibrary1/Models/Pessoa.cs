using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            Endereco = new List<Endereco>();
        }

        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int? Idade { get; set; }
        public System.DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}
