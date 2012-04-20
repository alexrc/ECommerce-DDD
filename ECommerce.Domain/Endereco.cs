using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain
{
    public class Endereco
    {
        public String Cep { get; set; }
        public String Logradouro { get; set; }
        public Int32 Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }
        public String Pais { get; set; }
    }
}
