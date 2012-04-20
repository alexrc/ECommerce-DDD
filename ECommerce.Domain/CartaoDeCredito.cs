using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain
{
    public class CartaoDeCredito : FormaDePagamento
    {
        public String NumeroCartao { get; set; }
        public String CodigoSeguranca { get; set; }
        public TipoCartaoDeCredito TipoCartaoDeCredito { get; set; }
        public String NomeNoCartao { get; set; }
        public short ValidadeMes { get; set; }
        public short ValidadeAno { get; set; }
    }
}
