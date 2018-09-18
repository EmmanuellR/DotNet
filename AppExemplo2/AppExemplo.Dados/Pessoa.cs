using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplo.Dados
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public IList<Telefone> Telefones { get; set; }

    }
}
