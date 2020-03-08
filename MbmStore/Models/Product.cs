using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        public string Title
        {
            get; set;
        }
     
        public string Imageurl
        {
            get; set;
        }
        private decimal price { get; set; }
        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }
      

        public Product() {}
        public Product (string title, decimal price, string imageurl)
        {
            Title = title;
            Price = price;
            Imageurl = imageurl;
            
        }

    }
}
