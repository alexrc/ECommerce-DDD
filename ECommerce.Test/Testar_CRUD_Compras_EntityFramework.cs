using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rhino.Mocks;
using NUnit.Framework;
using ECommerce.Domain.Repository;
using ECommerce.Domain;
using ECommerce.Domain.Factories;

namespace ECommerce.Test
{
    [TestFixture]
    [Ignore]
    public class Testar_CRUD_Compras_EntityFramework : ComprasTestBase
    {
        private IRepository<Compra> _compraRepository;
        //private IRepository<Compra> compraRepositoryMock;

        private Compra _compra;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _compraRepository = new ComprasRepository();

            //compraRepositoryMock = MockRepository.GenerateMock<ComprasRepository>();
           
            _compra = FabricaCompra.Criar();

            //_compra.AdicionarItem(CriarItemCompra());

            //compraRepositoryMock.Salvar(compra);

            //_compraRepository.Inserir(_compra);
        }

        [Test]
        [Ignore]
        public void Recuperar_Dados_Salvos_Corretamente()
        {
            var compraObtida = _compraRepository.BuscarPorId(_compra.CompraId);
            Assert.AreEqual(compraObtida.CompraId, _compra.CompraId);
        }

        [Test]
        [Ignore]
        public void Verificar_Chamadas()
        {
            //compraRepositoryMock.VerifyAllExpectations();
        }
    }
}
