using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Entities.DTOs
{
    public class MovementCreateDTO
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int productQuantity { get; set; }
        public DateTime movementDate { get; set; }
        public string movementConcept { get; set; }
        public string movementStatus { get; set; } // Active, processed, cancelled
        public int movementType { get; set; }
    }
}
