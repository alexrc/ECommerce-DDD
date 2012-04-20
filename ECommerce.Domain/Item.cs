using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Domain
{
    public class Item
    {
        public int ItemId { get; set; }
        public long ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public Int32 Quantidade { get; set; }
    }
}
