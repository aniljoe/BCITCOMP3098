using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CustomerServicesEntity;

namespace CustomerServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
                public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Customer> GetCustomers()
        {
            Customer customer = null;
            List<Customer> lstcust = new List<Customer>();
            using (var context = new CUSTOMERDATAEntities())
            {
                var customerEntity = (from cust in context.CustomerEntities select cust).ToList();
                if (customerEntity != null)
                    foreach (var cust in customerEntity)
                    {
                        customer = new Customer();
                        customer.CustomerId = cust.CustomerId;
                        customer.CustomerName = cust.CustomerName;
                        customer.Address = cust.Address;
                        customer.Email = cust.Email;
                        lstcust.Add(customer);
                    }
            }
            return lstcust;
        }

        public bool InsertCustomer(Customer obj)
        {
            CustomerEntity objcust = new CustomerEntity()
            {
                CustomerId = obj.CustomerId,
                CustomerName = obj.CustomerName,
                Address = obj.Address,
                Email = obj.Email
            };
            CUSTOMERDATAEntities db = new CUSTOMERDATAEntities();
            db.CustomerEntities.Add(objcust);
          
            //    db.AddToCustomerEntities(objcust);
            db.SaveChanges();
            return true;
        }


        public bool UpdateCustomer(Customer obj)
        {
            var custId = obj.CustomerId;
            using (CUSTOMERDATAEntities context = new CUSTOMERDATAEntities())
            {
                var customerEntity = (from c in context.CustomerEntities where c.CustomerId == custId select c).Single();
                if (customerEntity != null)
                {
                    customerEntity.CustomerId = obj.CustomerId;
                    customerEntity.CustomerName = obj.CustomerName;
                    customerEntity.Address = obj.Address;
                    customerEntity.Email = obj.Email;
                    context.CustomerEntities.Remove(customerEntity);
                    context.SaveChanges();
                    context.CustomerEntities.Add(customerEntity);
                    context.SaveChanges();
                }
            }

            return true;
        }


        public bool DeleteCustomer(int cid)
        {
            using (CUSTOMERDATAEntities context = new CUSTOMERDATAEntities())
            {
                var customerEntity = (from c in context.CustomerEntities where c.CustomerId == cid select c).Single();
                if (customerEntity != null)
                {
                    context.CustomerEntities.Remove(customerEntity);
                    context.SaveChanges();
                }
            }
            return true;
        }

        public bool DeleteCustomers()
        {
            
            using (CUSTOMERDATAEntities context = new CUSTOMERDATAEntities())
            {

                var customerEntity = (from cust in context.CustomerEntities select cust).ToList();
                context.CustomerEntities.RemoveRange(customerEntity);
            }
            return true;

        }

    }


}
