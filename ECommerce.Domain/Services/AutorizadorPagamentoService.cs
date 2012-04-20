using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain.Services
{
    public class AutorizadorPagamentoService
    {
        public StatusPagamento Verificar(FormaDePagamento FormaDePagamento, double Valor)
        {
            //TODO: Implementar funcionalidades da classe de serviço.
            return StatusPagamentoEnum.Autorizado;
        }
    }
}
