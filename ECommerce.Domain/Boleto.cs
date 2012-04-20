using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain
{
    public class Boleto : FormaDePagamento
    {
        public String CodigoDeBarras { get; set; }
        public DateTime Vencimento { get; set; }
    }
}
