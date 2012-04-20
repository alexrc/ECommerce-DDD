using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ECommerce.Domain;
using ECommerce.Domain.Factories;

namespace ECommerce.Test
{
    [TestFixture]
    public class Ao_Efetuar_Compra_De_Livro_Com_Cartao_De_Credito
    {
        #region Propriedades
        private Compra compra;
        private Pagamento _pagamentoCartao;
        private Item _itemDeCompra;
        private Produto _produto = new Livro();
        private int _quantidade = 2;
        private Double _peso = 0.5;
        private String _titulo = "Domain Driven Design: Atacando as Complexidades no Coração do Software";
        private String _autor = "Eric Evans";
        private CategoriaEnum _categoria = CategoriaEnum.Estudos;
        private String _editora = "Alta Books";
        private String _isbn = "978-85-7608-504-1";
        private Double _valor = 50.50;
        private String _codigoSeguranca = "782";
        private String _nomeNoCartao = "Paulo Loyola";
        private String _numeroDoCartao = "7894563212341121";
        private TipoCartaoDeCreditoEnum _tipoCartaoDeCredito = TipoCartaoDeCreditoEnum.MasterCard;
        private short _validadeAno = 2013;
        private short _validadeMes = 05;
        #endregion

        [TestFixtureSetUp]
        public void SetUp()
        {
            _produto = CriarProdutoLivro();
            _itemDeCompra = CriarItemCompra();
            _pagamentoCartao = CriarPagamentoCartao();

            compra = FabricaCompra.Criar();
            compra.AdicionarItem(_itemDeCompra);
            compra.Fechar();
            compra.InformarDadosPagamento(_pagamentoCartao);
            compra.Pagar();
        }

        private Produto CriarProdutoLivro()
        {
            return new Livro()
            {
                Peso = _peso,
                Titulo = _titulo,
                Autor = _autor,
                Categoria = _categoria,
                Editora = _editora,
                ISBN = _isbn,
                Valor = _valor
            };
        }

        private Item CriarItemCompra()
        {
            return
                new Item()
                {
                    Produto = _produto,
                    Quantidade = _quantidade
                };
        }

        private Pagamento CriarPagamentoCartao()
        {
            return new Pagamento()
            {
                FormaDePagamento = new CartaoDeCredito()
                {
                    CodigoSeguranca = _codigoSeguranca,
                    NomeNoCartao = _nomeNoCartao,
                    NumeroCartao = _numeroDoCartao,
                    TipoCartaoDeCredito = _tipoCartaoDeCredito,
                    ValidadeAno = _validadeAno,
                    ValidadeMes = _validadeMes
                }
            };
        }

        [Test]
        public void Compra_nao_pode_ser_nula()
        {
            Assert.NotNull(compra);
        }

        [Test]
        public void Status_da_compra_deve_ser_setado_corretamente()
        {
            Assert.AreEqual(compra.Status.Enum, StatusCompraEnum.Paga);
        }

        [Test]
        public void Status_do_pagamento_deve_ser_setado_corretamente()
        {
            Assert.AreEqual(compra.Pagamento.StatusPagamento.Enum, StatusPagamentoEnum.Autorizado);
        }

        [Test]
        public  void Forma_de_pagamento_deve_ser_cartao_de_credito()
        {
            Assert.AreEqual(typeof(CartaoDeCredito), compra.Pagamento.FormaDePagamento.GetType());
        }

        [Test]
        public void Compra_deve_ter_um_item_de_compra()
        {
            Assert.Contains(_itemDeCompra,compra.Itens.ToList());
        }

        [Test]
        public void Peso_deve_ser_calculado_corretamente()
        {
            Assert.AreEqual(_peso*_quantidade,compra.Peso);
        }

        [Test]
        public void Valor_deve_ser_calculado_corretamente()
        {
            Assert.AreEqual(_valor * _quantidade, compra.Valor);
        }

        [Test]
        public void Valor_do_pagamento_deve_ser_calculado_corretamente()
        {
            Assert.AreEqual(compra.Valor,compra.Pagamento.Valor);
        }

    }
}
