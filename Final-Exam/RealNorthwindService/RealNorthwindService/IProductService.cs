using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFServices.RealNorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        IEnumerable<Product> GetAllProducts();

        [OperationContract]
        bool UpdateProduct(Product product);

        [OperationContract]
        void AddProduct(Product product);

        [OperationContract]
        void DeleteProduct(Product product);
    }

    
}
