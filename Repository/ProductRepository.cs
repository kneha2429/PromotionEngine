using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProductList()
        {
            return new List<Product>{
              new Product() {ProductId ='A',Price= 50,ProductName= "ProductA" },
              new Product() {ProductId ='B',Price= 30,ProductName= "ProductB" },
              new Product() {ProductId ='C',Price= 20,ProductName= "ProductC" },
              new Product() {ProductId ='D',Price= 15,ProductName= "ProductD" }
           };
      }
    }
}
