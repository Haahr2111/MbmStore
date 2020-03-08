using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movielist = new List<Movie>();

            // create a new Movie object with instance name jungleBook
            var jungle = new Movie("Jungle Book", 160.50m, "/Images/junglebook.jpg", "Jon Favreau");

            // assign a ViewBag property to the new Movie object
 

            // create a new Movie object with instance name jungleBook
            var gladiator = new Movie("Gladiator", 160.50m, "/Images/gladiator.jpg", "Ridley Scott");

            var forrestgump = new Movie("Forrest Gump", 160.50m, "/Images/forrest-gump.jpg", "Rasmus Haahr");
            // assign a ViewBag property to the new Movie object

            movielist.Add(jungle);
            movielist.Add(gladiator);
            movielist.Add(forrestgump);


            ViewBag.movies = movielist;
            
            // return the default view
            return View();
        }
    }
}