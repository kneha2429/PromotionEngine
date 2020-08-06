using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Repository
{
    public class PromotionTypeARepository : IPromotionRepository
    {
        public decimal GetPromotionPrice(List<Order> orders)
        {
            decimal totalOrderPrice = 0;

            foreach (Order order in orders)
            {
                if (order.ProductId == 'A')
                {
                    totalOrderPrice = ((order.Quantity / 3) * 130) + (order.Quantity % 3 * order.Price);
                }
                else if (order.ProductId == 'B')
                {
                    totalOrderPrice = ((order.Quantity / 2) * 45) + (order.Quantity % 2 * order.Price);
                }
                else
                {
                    totalOrderPrice = order.Quantity * order.Price;
                }
            
            }
            return totalOrderPrice;
        }
    }
}
