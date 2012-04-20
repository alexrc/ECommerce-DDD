using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain.Factories
{
    public class FabricaCompra
    {
        public static Compra Criar()
        {
            var itens = new List<Item>();
            var statusCompra = StatusCompraEnum.EmAberto;

            return new Compra(itens,statusCompra);

        }
    }
}
