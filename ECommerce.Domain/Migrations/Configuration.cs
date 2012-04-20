using System.Collections.Generic;
using ECommerce.Domain.Repository;
using ECommerce.Infraestructure;
using System.Data.Entity.Migrations;


namespace ECommerce.Domain.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<ECommerceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ECommerceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            PopularTabelasTipoEnum(context);
        }

        private void PopularTabelasTipoEnum(ECommerceContext context)
        {
            PopularTabelaStatusCompra(context);

            PopularTabelaStatusPagamento(context);

            PopularTabelaCategoria(context);

            PopularTabelaTipoCartaoDeCredito(context);
        }

        private void PopularTabelaStatusPagamento(ECommerceContext context)
        {
            var statusPagamentoList = new EnumExtensions<StatusPagamentoEnum>().ConvertToList();

            statusPagamentoList.ForEach(kvp => context.StatusPagamentos.AddOrUpdate(
                new StatusPagamento()
                    {
                        Id = kvp.Key,
                        //Value = kvp.Value
                    }));
        }

        private void PopularTabelaStatusCompra(ECommerceContext context)
        {
            var statusCompraList = new EnumExtensions<StatusCompraEnum>().ConvertToList();

            statusCompraList.ForEach(kvp => context.StatusCompras.AddOrUpdate(
                new StatusCompra()
                    {
                        Id = kvp.Key,
                        //Value = kvp.Value
                    }));
        }
        
        private void PopularTabelaCategoria(ECommerceContext context)
        {
            var categoriaList = new EnumExtensions<CategoriaEnum>().ConvertToList();

            categoriaList.ForEach(kvp => context.Categorias.AddOrUpdate(
                new Categoria()
                {
                    Id = kvp.Key,
                    //Value = kvp.Value
                }));
        }

        private void PopularTabelaTipoCartaoDeCredito(ECommerceContext context)
        {
            var tipoCartoesList = new EnumExtensions<TipoCartaoDeCreditoEnum>().ConvertToList();

            tipoCartoesList.ForEach(kvp => context.TipoCartoesDeCredito.AddOrUpdate(
                new TipoCartaoDeCredito()
                {
                    Id = kvp.Key,
                    //Value = kvp.Value
                }));

        }

    }
}
