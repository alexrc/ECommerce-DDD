using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Infraestructure
{
    public abstract class EnumWrapper<TEnum> where TEnum : struct, IConvertible
    {
        public EnumWrapper()
        {
            if (!typeof(TEnum).IsEnum)
                throw new ArgumentException("Not an enum");
        }

        public TEnum Enum { get; set; }

        public int Id
        {
            get { return Convert.ToInt32(Enum); }
            set { Enum = (TEnum)(object)value; }
        }

        public static implicit operator int(EnumWrapper<TEnum> w)
        {
            return w == null ? Convert.ToInt32(default(TEnum)) : w.Id;
        }
    }
}
