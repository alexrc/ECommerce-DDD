using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain
{
    public abstract class Pessoa
    {
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public CartaoDeCredito CartaoDeCredito { get; set; }
    }
}
