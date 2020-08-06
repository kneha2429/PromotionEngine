using PromotionEngine.Model;
using PromotionEngine.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class OrderProcessing
    {
        private readonly IPromotionRepository promotionRepository;
        private readonly IProductRepository productRepository;
        private readonly IOrderRepository orderRepository;

        public OrderProcessing(IPromotionRepository promotionRepository, IProductRepository productRepository, IOrderRepository
            orderRepository)
        {
            this.promotionRepository = promotionRepository;
            this.productRepository = productRepository;
            this.orderRepository = orderRepository;
        }

        public decimal StartProcessing()
        {
            List<Product> products = this.productRepository.GetProductList();
            List<Order> orders = this.orderRepository.GetOrderDetails(products);
            return this.promotionRepository.GetPromotionPrice(orders);
        }
    }
}
