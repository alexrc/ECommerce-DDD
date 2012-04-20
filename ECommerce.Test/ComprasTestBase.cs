using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Domain;

namespace ECommerce.Test
{
    public abstract class ComprasTestBase
    {
        internal Compra compras;

        internal Item CriarItemCompra()
        {
            return
                new Item()
                {
                    Produto = new Livro()
                    {
                        ProdutoId = 1,
                        Peso = 0.5,
                        Titulo = "Domain Driven Design: Atacando as Complexidades no Coração do Software",
                        Autor = "Eric Evans",
                        Categoria = CategoriaEnum.Estudos,
                        Editora = "Alta Books",
                        ISBN = "978-85-7608-504-1",
                        Valor = 50
                    },
                    Quantidade = 1
                };
        }


    }
}
