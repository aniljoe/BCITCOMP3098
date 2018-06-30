using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealNorthwindClient.ProductServiceRef;

namespace RealNorthwindClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServiceClient serviceClient = new ProductServiceClient();
            List<Product> products = serviceClient.GetAllProducts().ToList();

            foreach(Product product in products)
            {
                Console.WriteLine(product.ProductName);
            }
          
        }
    }
}
