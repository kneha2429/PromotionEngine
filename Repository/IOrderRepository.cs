using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Repository
{
  public interface  IOrderRepository
    {
        List<Order> GetOrderDetails(List<Product> products);
    }
}
