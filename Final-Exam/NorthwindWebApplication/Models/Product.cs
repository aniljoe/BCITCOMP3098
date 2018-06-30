using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindWebApplication.Models
{
    public class Product
    {

 
        public int ProductID { get; set; }
      
        public string ProductName { get; set; }
    
        public string QuantityPerUnit { get; set; }
     
        public decimal UnitPrice { get; set; }

        public bool Discontinued { get; set; }
    }
}