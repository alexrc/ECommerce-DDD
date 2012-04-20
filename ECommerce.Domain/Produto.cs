using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain
{
    public abstract class Produto
    {
        public long ProdutoId { get; set; }
        public Double Peso { get; set; }
        public Double Valor { get; set; }
    }

}
