using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Infraestructure;

namespace ECommerce.Domain
{
    public enum TipoCartaoDeCreditoEnum
    {
        Visa = 1,
        MasterCard = 2,
        Amex = 3
    }

    public class TipoCartaoDeCredito : EnumWrapper<TipoCartaoDeCreditoEnum>
    {
        public static implicit operator TipoCartaoDeCredito(TipoCartaoDeCreditoEnum e)
        {
            return new TipoCartaoDeCredito() { Enum = e };
        }
    }

}
