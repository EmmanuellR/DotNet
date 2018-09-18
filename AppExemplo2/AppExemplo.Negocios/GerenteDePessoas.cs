using AppExemplo.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplo.Negocios
{
    public class GerenteDePessoas
    {
        IList<Pessoa> pessoas = new List<Pessoa>();

        public void Adiciona(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

        public IList<Pessoa> Todas()
        {
            return pessoas;
        }

    }
}
