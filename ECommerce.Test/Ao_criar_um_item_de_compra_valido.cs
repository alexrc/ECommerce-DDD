using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ECommerce.Domain;

namespace ECommerce.Test
{
    [TestFixture]
    public class Ao_criar_um_item_de_compra_valido
    {
        private Item _itemDeCompra;
        private Produto _produto = new Livro();
        private Double _peso = 0.5;
        private String _titulo = "Domain Driven Design: Atacando as Complexidades no Coração do Software";

        [TestFixtureSetUp]
        public void SetUp()
        {
            _produto = CriarProdutoLivro();
            _itemDeCompra = CriarItemCompra();
        }

        private Produto CriarProdutoLivro()
        {
            return new Livro()
                       {
                           Peso = _peso,
                           Titulo = _titulo,
                           Autor = "Eric Evans",
                           Categoria = CategoriaEnum.Estudos,
                           Editora = "Alta Books",
                           ISBN = "978-85-7608-504-1",
                           Valor = 50
                       };
        }

        private Item CriarItemCompra()
        {
            return
                new Item()
                {
                    Produto = _produto,
                    Quantidade = 1
                };
        }

        [Test]
        public void O_item_nao_pode_ser_nulo()
        {
            Assert.NotNull(_itemDeCompra);
        }

        [Test]
        public void O_peso_do_produto_deve_ser_mapeado_corretamente()
        {
            Assert.AreEqual(_peso, _itemDeCompra.Produto.Peso);
        }

    }
}
