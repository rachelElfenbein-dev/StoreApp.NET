using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product
        (
        int id,
        string? name,
        Categories? category,
        double price,
        int? quantity
        )
    {
        public Product():this(0,null,null,0,0)
        {
        }
    }
}
