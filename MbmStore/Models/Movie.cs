using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie :Product
    {
        // fields
        
       

        // properties

        public string Director { get; set; }


    // constructors
    public Movie() { }

        

        public Movie(string title, decimal price, string imageurl, string director) : base (title, price, imageurl)
        {
            Director = director;
        }
    }
}