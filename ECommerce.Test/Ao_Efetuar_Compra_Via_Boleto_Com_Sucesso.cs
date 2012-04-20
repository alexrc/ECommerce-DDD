using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Domain.Factories;
using NUnit.Framework;
using ECommerce.Domain;
using Rhino.Mocks;

namespace ECommerce.Test
{
    [TestFixture]
    public class Ao_Efetuar_Compra_Via_Boleto_Com_Sucesso
    {
        private Pagamento pagamentoBoleto;
        private Compra _compra;
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

        [TestFixtureSetUp]
        public void SetUp()
        {
            _compra = FabricaCompra.Criar();
            _itemDeCompra = CriarItemCompra();
            _produto = CriarProdutoLivro();

            _compra.AdicionarItem(_itemDeCompra);
            pagamentoBoleto = CriarPagamentoBoleto();
            _compra.InformarDadosPagamento(pagamentoBoleto);

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

        private Pagamento CriarPagamentoBoleto()
        {
            return new Pagamento()
                       {
                           FormaDePagamento = new Boleto()
                                                  {
                                                      CodigoDeBarras = "1231321321321321",
                                                      Vencimento = new DateTime(2012,03,15)
                                                  }
                       };
        }

        [Test]
        public void Compra_nao_pode_ser_nula()
        {
            Assert.NotNull(_compra);
        }

        [Test]
        public void Item_nao_pode_ser_nulo()
        {
            Assert.IsNotNull(_itemDeCompra);
        }

        [Test]
        public void Item_deve_ser_adicionado_a_compra_corretamente()
        {
            Assert.IsTrue(_compra.Itens.Count > 0);
        }

        [Test]
        public void Pagamento_Nao_Deve_Ser_Nulo()
        {
            Assert.IsNotNull(_compra.Pagamento);
        }

        [Test]
        public void Forma_De_Pagamento_Deve_Ser_Boleto()
        {
            Assert.AreEqual(typeof(Boleto), pagamentoBoleto.FormaDePagamento.GetType());
        }
    }
}
