using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetOrderDetails(List<Product> products)
        {
            int productCount = 0;
            List<Order> orderList = null;
            Console.WriteLine("Order Placement : Please select the product and provide quantity");
            foreach (Product product in products)
            {
                Console.WriteLine("Product : {0}", product.ProductName);
                productCount = int.Parse(Console.ReadLine());
                Order order = new Order()
                {
                    ProductId = product.ProductId,
                    Quantity = productCount,
                    Price = product.Price
                };
                orderList.Add(order);
            }
            return orderList;
        }
    }
}
