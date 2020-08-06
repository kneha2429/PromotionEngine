using PromotionEngine.Model;
using PromotionEngine.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromotionEngine.Utilities.Enums;

namespace PromotionEngine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the Promotion Type : 1 -> Type A : 2 -> Type B");
            var promoType = char.Parse(Console.ReadLine());
            IPromotionRepository promotionRepository = new PromotionManager().GetPromotionInstance(promoType);
            IProductRepository productRepository = new ProductRepository();
            IOrderRepository orderRepository = new OrderRepository();
            OrderProcessing orderProcessing = new OrderProcessing(promotionRepository,productRepository,orderRepository);
            decimal totalOrderPrice = orderProcessing.StartProcessing();
        }

        
    }
}
