using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NorthwindWebApplication.Models;
using NorthWindEntities;

namespace NorthwindWebApplication.Controllers
{
    public class ProductsController : ApiController
    {

        public IEnumerable<Product> GetAllProducts()
        {
            NorthwindEntities context = new NorthwindEntities();
            var productEnties = context.ProductEntities;
            List<Product> products = new List<Product>();
            foreach(ProductEntity entity in productEnties)
            {
                products.Add(TransformEntityToProduct(entity));
            }

            return products;
        }

        
        public IHttpActionResult GetProduct(int id)
        {
            NorthwindEntities context = new NorthwindEntities();
            var productEntity = context.ProductEntities.FirstOrDefault(c => c.ProductID == id);
            //return TransformEntityToProduct(productEntity);
            return Ok(TransformEntityToProduct(productEntity));
        }

        [Route("api/products/update")]
        [HttpPut]
        public bool UpdateProduct(Product product)
        {
            if (product != null)
            {
                using (var conext = new NorthwindEntities())
                {
                    ProductEntity productEntity = conext.ProductEntities.FirstOrDefault(x => x.ProductID == product.ProductID);
                    productEntity = TransformProductToEntity(product);
                    return (conext.SaveChanges() > 0) ? true : false;
                }
            }

            return false;
        }

        [Route("api/products/add")]
        [HttpPost]
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                using (var conext = new NorthwindEntities())
                {
                    conext.ProductEntities.Add(TransformProductToEntity(product));
                    conext.SaveChanges();
                }
            }
        }

        [Route("api/products/delete")]

        [HttpDelete]
        public void DeleteProduct(Product product)
        {
            if (product != null)
            {
                using (var conext = new NorthwindEntities())
                {
                    ProductEntity productEntity = conext.ProductEntities.FirstOrDefault(x => x.ProductID == product.ProductID);
                    productEntity = TransformProductToEntity(product);
                    conext.ProductEntities.Remove(productEntity);
                    conext.SaveChanges();
                }
            }
        }

        private Product TransformEntityToProduct(ProductEntity productEntity)
        {
            Product product = new Product();
            product.ProductID = productEntity.ProductID;
            product.ProductName = productEntity.ProductName;
            product.QuantityPerUnit = productEntity.QuantityPerUnit;
            product.UnitPrice = (decimal)productEntity.UnitPrice;
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
}
