using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Domain.Factories;
using ECommerce.Domain.Services;

namespace ECommerce.Domain
{
    public class Compra
    {
        #region Propriedades
        public long CompraId { get; private set; }
        public ICollection<Item> Itens { get; private set; }
        public StatusCompra Status { get; set; }
        public Double Valor { get; set; }
        public Double Peso { get; set; }
        public Pagamento Pagamento { get; private set; }
        #endregion

        #region Construtores
        public Compra(ICollection<Item> itens, StatusCompra statusCompraEnum)
        {
            Itens = itens;
            Status = statusCompraEnum;
        }
        public Compra()
        {

        }
        #endregion

        #region Métodos
        public void AdicionarItem(Item itemCompra)
        {
            Itens.Add(itemCompra);
        }
        public void Fechar()
        {
            Valor = CalcularValor();
            Peso = CalcularPeso();
            Status = StatusCompraEnum.AguardandoAutorizacaoPagamento;
        }
        public void EncerrarComoPagas()
        {
            Status = StatusCompraEnum.Paga;
        }
        //public void Cancelar()
        //{
        //    StatusCompra = StatusCompra.Cancelada;
        //}
        private Double CalcularValor()
        {
            return Itens.Sum(itemCompra => itemCompra.Produto.Valor * itemCompra.Quantidade);
        }
        private Double CalcularPeso()
        {
            return Itens.Sum(itemCompra => itemCompra.Produto.Peso * itemCompra.Quantidade);
        }
        public void InformarDadosPagamento(Pagamento pagamento)
        {
            Pagamento = pagamento;
            Pagamento.Valor = Valor;
        }
        public void Pagar()
        {
            Pagamento.Efetuar();

            Status = Pagamento.StatusPagamento.Enum== StatusPagamentoEnum.Autorizado ? 
                StatusCompraEnum.Paga :  
                StatusCompraEnum.Pendente;
        }
        #endregion

    }
}
