﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem
    {
        public Product Product{ get; set; }

        public int Quantity { get; set;}
        public OrderItem (Product product, int qunatity)
        {
            Product = product;
            Quantity = qunatity;

        }
    }
}
