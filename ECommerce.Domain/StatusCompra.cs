using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using ECommerce.Domain.Repository;
using ECommerce.Infraestructure;

namespace ECommerce.Domain
{
    public enum StatusCompraEnum : int
    {
        EmAberto = 1,
        Cancelada = 2,
        AguardandoAutorizacaoPagamento = 3,
        Paga = 4,
        EmTransito = 5,
        Entregue = 6,
        Pendente = 7
    }
    
    public class StatusCompra : EnumWrapper<StatusCompraEnum>
    {
        public static implicit operator StatusCompra(StatusCompraEnum e)
        {
            return new StatusCompra() { Enum = e };
        }
    }
}
