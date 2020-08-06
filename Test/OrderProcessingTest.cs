using Moq;
using PromotionEngine.Repository;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        //public void CheckProductListException()
        //{ 
        //    Action act = () => orderProcessing.

        //}

    }

    
}
