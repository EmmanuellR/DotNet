using AppExemplo.Dados;
using AppExemplo.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemplo.Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cria pessoas");
            
            /// Criar 5 pessoas
            Pessoa pessoa = new Pessoa();


            GerenteDePessoas gerente = new GerenteDePessoas();

            Console.WriteLine("Adiciona pessoas aa lista");

            // Adiciona pessoas aa lista
            gerente.Adiciona(pessoa);

            Console.WriteLine("Lista pessoas e telefones");

            int contador = 0;

            foreach (var pessoaLocal in gerente.Todas())
            {
                Console.WriteLine(pessoaLocal.Nome);
                foreach (var telefone in pessoaLocal.Telefones)
                {
                    contador = contador + 1;

                    Console.WriteLine(telefone.Numero);
                }
            }

            Console.WriteLine("Quantidade de telefones cadastrados");
            Console.WriteLine(contador);

            Console.Read();
        }
    }
}
