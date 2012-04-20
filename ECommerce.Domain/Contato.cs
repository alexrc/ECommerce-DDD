using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain
{
    public class Contato
    {
        public ICollection<Telefone> Telefones { get; set; }
        public String Email { get; set; }
    }
}
