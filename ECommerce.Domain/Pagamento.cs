using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Domain.Services;

namespace ECommerce.Domain
{
    public class Pagamento
    {
        public long? PagamentoId { get; set; }
        public short FormaDePagamentoId { get; set; }
        public virtual FormaDePagamento FormaDePagamento { get; set; }
        public int StatusPagamentoId { get; set; }
        public virtual StatusPagamento StatusPagamento { get; private set; }
        public Double Valor { get; set; }

        public Pagamento()
        {
            StatusPagamento = StatusPagamentoEnum.AguardandoAutorizacao;
        }

        public void Efetuar()
        {
            var autorizadorPagamentoService = new AutorizadorPagamentoService();
            StatusPagamento = autorizadorPagamentoService.Verificar(FormaDePagamento,Valor);
        }
    }
}
