using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ECommerce.Infraestructure
{ 
    public class EnumExtensions<E> where E : new()
    {
        public List<KeyValuePair<int,string>> ConvertToList()
        {
            return Enum.GetValues(new E().GetType())
                    .Cast<Enum>()
                    .ToDictionary(Convert.ToInt32, t => t.ToString())
                    .ToList();
        }
    }
}
