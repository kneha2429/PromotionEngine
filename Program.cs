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
        private readonly IPromotionRepository promotionRepository;
        private readonly IProductRepository productRepository;
        private readonly IOrderRepository orderRepository;

        public Program(IPromotionRepository promotionRepository, IProductRepository productRepository , IOrderRepository
            orderRepository)
        {
            this.promotionRepository = promotionRepository;
            this.productRepository = productRepository;
            this.orderRepository = orderRepository;
        }

        static void Main(string[] args)
        {
            IPromotionRepository promotionRepository = new PromotionTypeARepository();
            IProductRepository productRepository = new ProductRepository();
            IOrderRepository orderRepository = new OrderRepository();

            Program pg = new Program(promotionRepository, productRepository, orderRepository);
            decimal totalPrice = pg.StartProcessing();
        }

        public decimal StartProcessing()
        {
            List<Product> products = this.productRepository.GetProductList();
            List<Order> orders = this.orderRepository.GetOrderDetails(products);
            return this.promotionRepository.GetPromotionPrice(orders);
       }
    }
}
