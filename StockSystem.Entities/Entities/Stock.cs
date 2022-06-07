using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Entities.Entities
{
    public abstract class Stock
    {
        public int productId { get; set; }
        public string productName { get; set; }
    }
}
