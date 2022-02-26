using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entidades
{
    class Endereco
    {
        public int id { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Referencia { get; set; }
        public string Apelido { get; set; }
        public bool HeEnderecoPrincipal { get; set; }
    }
}
