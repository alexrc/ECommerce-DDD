using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace ECommerce.Domain.Repository
{
    public class ECommerceContext : DbContext
    {
        #region Propriedades
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Boleto> Boletos { get; set; }
        public DbSet<CartaoDeCredito> CartoesDeCredito { get; set; }
        public DbSet<TipoCartaoDeCredito> TipoCartoesDeCredito { get; set; }
        public DbSet<StatusCompra> StatusCompras { get; set; }
        public DbSet<StatusPagamento> StatusPagamentos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<FormaDePagamento> FormasDePagamento { get; set; }
        #endregion

        #region Construtores

        public ECommerceContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ECommerceContext>());
        }

        #endregion
    }
}
