using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Entities.Entities
{
    public class Movement: Stock
    {
        public int movementId { get; set; }
        public int productQuantity { get; set; }
        public DateTime movementDate { get; set; }
        public string movementConcept { get; set; }
        public string movementStatus { get; set; } // Active, processed, cancelled
        public int movementType { get; set; } // 1 -> entrada, -1 -> salida
    }
}
