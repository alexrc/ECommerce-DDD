using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Infraestructure;

namespace ECommerce.Domain
{
    public enum CategoriaEnum
    {
        Infantil = 1,
        Jogos = 2,
        Estudos = 3
    }

    public class Categoria : EnumWrapper<CategoriaEnum>
    {
        public static implicit operator Categoria(CategoriaEnum e)
        {
            return new Categoria() { Enum = e };
        }
    }

}
