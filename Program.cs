using PromotionEngine.Model;
using PromotionEngine.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IPromotionRepository promotionRepository = new PromotionTypeARepository();
            IProductRepository productRepository = new ProductRepository();
            IOrderRepository orderRepository = new OrderRepository();
            OrderProcessing orderProcessing = new OrderProcessing(promotionRepository,productRepository,orderRepository);
            decimal totalOrderPrice = orderProcessing.StartProcessing();
        }

        
    }
}
