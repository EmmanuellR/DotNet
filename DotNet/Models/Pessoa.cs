using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public List<Telefone> Telefone { get; set; }
        public Endereco Endereco { get; set; }
    }
}