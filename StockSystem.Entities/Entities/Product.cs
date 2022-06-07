using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Entities.Entities
{
    public class Product: Stock
    {
        public double productPrice { get; set; }
        public string productDescription { get; set; }
        public int productUnitOfMeasurement { get; set; }
        public string productBarCode { get; set; }
        public int productStockBalance { get; set; }
        public string productStatus { get; set; } // Available, not available

    }
}
