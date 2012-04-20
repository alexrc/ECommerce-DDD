using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain
{
    public class Usuario : Pessoa
    {
        public String Login { get; set; }
        public String Senha { get; set; }
    }
}
