//using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NorthWindEntities;

namespace MyWCFServices.RealNorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ProductService : IProductService
    {

        public IEnumerable<Product> GetAllProducts()
        {
            NorthwindEntities context = new NorthwindEntities();
            var productEnties = context.ProductEntities;
            List<Product> products = new List<Product>();
            foreach (ProductEntity entity in productEnties)
            {
                products.Add(TransformEntityToProduct(entity));
            }

            return products;
        }

        public Product GetProduct(int id)
        {
            NorthwindEntities context = new NorthwindEntities();
            var productEntity = context.ProductEntities.FirstOrDefault(c => c.ProductID == id);
            return TransformEntityToProduct(productEntity);
        }

        public bool UpdateProduct(Product product)
        {
            if (product != null)
            {
                using (var conext = new NorthwindEntities())
                {
                    ProductEntity productEntity = conext.ProductEntities.FirstOrDefault(x => x.ProductID == product.ProductID);
                    productEntity.ProductID = product.ProductID;
                    productEntity.ProductName = product.ProductName;
                    productEntity.QuantityPerUnit = product.QuantityPerUnit;
                    productEntity.UnitPrice = (decimal)product.UnitPrice;
                    productEntity.Discontinued = product.Discontinued;
                    return (conext.SaveChanges() > 0) ? true : false;
                }
            }

            return false;
        }

        public void AddProduct(Product product)
        {
            if (product != null)
            {
                using (var conext = new NorthwindEntities())
                {
                    ProductEntity productEntity = TransformProductToEntity(product);
                    conext.ProductEntities.Add(productEntity);
                    conext.SaveChanges();
                }
            }
        }

        public void DeleteProduct(Product product)
        {
            if (product != null)
            {
                using (var conext = new NorthwindEntities())
                {
                    ProductEntity productEntity = conext.ProductEntities.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                    if (productEntity != null)
                    {
                        conext.ProductEntities.Remove(productEntity);
                        conext.SaveChanges();
                    }
                }
            }
        }

        private Product TransformEntityToProduct(ProductEntity productEntity)
        {
            Product product = new Product();
            product.ProductID = productEntity.ProductID;
            product.ProductName = productEntity.ProductName;
            product.QuantityPerUnit = productEntity.QuantityPerUnit;
            product.UnitPrice = (decimal) productEntity.UnitPrice;
            product.Discontinued = productEntity.Discontinued;
            return product;

        }


        private ProductEntity TransformProductToEntity(Product product)
        {
            ProductEntity productEntity = new ProductEntity();
            productEntity.ProductID = product.ProductID;
            productEntity.ProductName = product.ProductName;
            productEntity.QuantityPerUnit = product.QuantityPerUnit;
            productEntity.UnitPrice = (decimal)product.UnitPrice;
            productEntity.Discontinued = product.Discontinued;
            return productEntity;

        }
    }

    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string QuantityPerUnit { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
        [DataMember]
        public bool Discontinued { get; set; }
    }
}
