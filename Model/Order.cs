using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
   public class Order
    {
        public int OrderId { get; set; }
        public char ProductId { get; set; }

        public decimal Price { get; set; }

        public char PromotionType { get; set; }


    }
}
