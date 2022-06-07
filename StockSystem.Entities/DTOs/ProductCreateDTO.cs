using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Entities.DTOs
{
    public class ProductCreateDTO
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public string productDescription { get; set; }
        public int productUnitOfMeasurement { get; set; }
        public string productBarCode { get; set; }
        public int productStockBalance { get; set; }
        public string productStatus { get; set; }
    }
}
