﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Customer
    {
        
            public int CustomerId { get; set; }
           
            public string CustomerName { get; set; }
          
            public string Address { get; set; }
           
            public string Email { get; set; }
        }
    }