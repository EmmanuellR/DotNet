﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class3: IPessoa
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string retornaCPF()
        {
            return this.Cpf;
        }
    }
}
