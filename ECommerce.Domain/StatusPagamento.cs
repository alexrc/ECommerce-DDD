using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Infraestructure;

namespace ECommerce.Domain
{
    public enum StatusPagamentoEnum
    {
        AguardandoAutorizacao = 1,
        NaoAutorizado = 2,
        Bloqueado = 3,
        Autorizado = 4,
        EmAberto = 5
    }

    public class StatusPagamento : EnumWrapper<StatusPagamentoEnum>
    {
        public static implicit operator StatusPagamento(StatusPagamentoEnum e)
        {
            return new StatusPagamento() { Enum = e };
        }
    }
}
