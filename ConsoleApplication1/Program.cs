using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Pessoa pessoa3 = new Pessoa();
            Pessoa pessoa4 = new Pessoa();
            Pessoa pessoa5 = new Pessoa();

            pessoa1.Nome ="Joao";
            pessoa1.Cpf = "11223344556";
            pessoa1.Profissao = "Pedreiro";
            pessoa2.Nome = "José";
            pessoa2.Cpf = "11223454556";
            pessoa2.Profissao = "Padeiro";
            pessoa3.Nome = "Eduardo";
            pessoa3.Cpf = "11223344875";
            pessoa3.Profissao = "Policial";
            pessoa4.Nome = "Francisco";
            pessoa4.Cpf = "14823344556";
            pessoa4.Profissao = "Professor";
            pessoa5.Nome = "Caio";
            pessoa5.Cpf = "11345344556";
            pessoa5.Profissao = "Estudante";

            List<Pessoa> lista = new List<Pessoa>();

            lista.Add(pessoa1);
            lista.Add(pessoa2);
            lista.Add(pessoa3);
            lista.Add(pessoa4);
            lista.Add(pessoa5);

            foreach (var pessoa in lista)
            {
                Console.WriteLine(pessoa.Nome + " " + pessoa.Cpf + " " + pessoa.Profissao);
               
            }

            int[] idades  = new int[] { 10, 12, 35, 58, 26, 24, 16, 19, 18, 17 };

            Array.Sort(idades);

            string saida = "[";
            foreach (var item in idades)
            {
                saida += item +",";
            }
            saida += "]";
            Console.WriteLine(saida);
           
            Console.Read();


        }
    }
}
