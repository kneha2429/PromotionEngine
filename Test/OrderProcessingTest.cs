using Moq;
using PromotionEngine.Model;
using PromotionEngine.Repository;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PromotionEngine.Test
{
    public class OrderProcessingTest
    {
      
        private readonly Mock<IPromotionRepository> _promotionRepository;
        private readonly Mock<IProductRepository> _productRepository;
        private readonly Mock<IOrderRepository> _orderRepository;
        private readonly OrderProcessing orderProcessing;

        public OrderProcessingTest()
        {
            _promotionRepository = new Mock<IPromotionRepository>();
            _productRepository = new Mock<IProductRepository>();
            _orderRepository = new Mock<IOrderRepository>();
            orderProcessing = new OrderProcessing(_promotionRepository.Object, _productRepository.Object, _orderRepository.Object);
        }


        [Fact]
        public void CheckProductListException()
        {

            Action act = () => orderProcessing.GetProduct();

            var exception = Assert.Throws<NotImplementedException>(act);

            Assert.Equal("Method Not Implemented",exception.Message);

        }

        [Fact]
        public void CheckOrderListException()
        {
            List<Product> product = new List<Product>();
            Action act = () => orderProcessing.GetOrders(product);

            var exception = Assert.Throws<NotImplementedException>(act);

            Assert.Equal("Method Not Implemented", exception.Message);

        }

        [Fact]
        public void CheckPromotionException()
        {
            List<Order> orders = new List<Order>();

            Action act = () => orderProcessing.GetTotalPrice(orders);

            var exception = Assert.Throws<NotImplementedException>(act);

            Assert.Equal("Method Not Implemented", exception.Message);

        }

    }

    
}
