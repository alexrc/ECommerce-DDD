using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Domain;
using ECommerce.Infraestructure;
using NUnit.Framework;

namespace ECommerce.Test
{
    internal enum TesteEnum
    {
        teste1 = 1,
        teste2 = 2
    }

    [TestFixture]
    public class Ao_converter_Enum_para_lista
    {
        private List<KeyValuePair<int, string>> lista;
        private TesteEnum enumTeste;
        private bool teste = true;
        private int enumCount;

        [TestFixtureSetUp]
        public void SetUp()
        {
            lista = new EnumExtensions<TesteEnum>().ConvertToList();

            foreach (var keyValuePair in lista)
                if (teste)
                    teste = TesteEnum.TryParse(keyValuePair.Value, out enumTeste);
                else
                    break;

            enumCount = Enum.GetValues(typeof(TesteEnum)).Cast<TesteEnum>().Count();

        }

        [Test]
        public void Lista_nao_pode_voltar_vazia()
        {
            Assert.Greater(lista.Count, default(int));
        }

        [Test]
        public void Lista_deve_conter_itens_do_Enum()
        {
            Assert.True(teste);
        }

        [Test]
        public void Lista_deve_conter_a_mesma_quantidade_de_itens_do_enum()
        {
            Assert.AreEqual(enumCount,lista.Count);
        }

    }
}
