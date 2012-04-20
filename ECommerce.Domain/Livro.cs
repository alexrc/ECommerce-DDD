using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain
{
    public class Livro : Produto
    {
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public String ISBN { get; set; }
        public short CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public String Editora { get; set; }
    }

}
