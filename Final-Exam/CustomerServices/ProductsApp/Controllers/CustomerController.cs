using CustomerServicesEntity;
using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class CustomerController : ApiController
    {
        public List<Models.Customer> GetCustomers()
        {
            Models.Customer customer = null;
            List<Models.Customer> lstcust = new List<Models.Customer>();
            using (var context = new CUSTOMERDATAEntities())
            {
                var customerEntity = (from cust in context.CustomerEntities select cust).ToList();
                if (customerEntity != null)
                    foreach (var cust in customerEntity)
                    {
                        customer = new Models.Customer();
                        customer.CustomerId = cust.CustomerId;
                        customer.CustomerName = cust.CustomerName;
                        customer.Address = cust.Address;
                        customer.Email = cust.Email;
                        lstcust.Add(customer);
                    }
            }
            return lstcust;
        }

        
        [HttpPost]
        public bool InsertCustomer(Models.Customer obj)

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


        public bool UpdateCustomer(Models.Customer obj)
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

        public Models.Customer GetCustomer(int id)
        {
            Models.Customer cust = new Models.Customer();
            CUSTOMERDATAEntities context = new CUSTOMERDATAEntities();
            var customerEntity = (from c in context.CustomerEntities where c.CustomerId == id select c).Single();
            cust.CustomerId = customerEntity.CustomerId;
            cust.CustomerName = customerEntity.CustomerName;
            cust.Address = customerEntity.Address;
            cust.Email = customerEntity.Email;

            return cust;
        }


    }
}
