using Chain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spread.Data.Request.requestDto
{
    public class ProductRequestDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public Color Color { get; set; }
        public Dimension Dimension { get; set; }
        public int Stock { get; set; }  
    }
}
