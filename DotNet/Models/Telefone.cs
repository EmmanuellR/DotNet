using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet.Models
{
    public class Telefone
    {
        public int TelefoneID { get; set; }
        public string NumeroTelefone { get; set; }
        public enum TipoDeContato { telefonefixo, telefonecomercial }
    }
}