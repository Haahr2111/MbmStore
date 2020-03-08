using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {

           

            List<Book> books = new List<Book>();
            Book b1 = new Book ("Stanley Kubrick","The Shining", 150, 28-1-1977, "/Images/shining.jfif");
            Book b2 = new Book("Gud", "Biblen", 250, 0-0-0, "/Images/bible.jfif");

            books.Add(b1);
            books.Add(b2);
           
            List<MusicCD> musiclist = new List<MusicCD>();
            

            var Beatles = new MusicCD ("Beatles", "Abbey Road", 125, 26-9-1969, "/Images/abbey.jfif");

            Beatles.AddTracks(new Track ("Come together", "John Lennon", new TimeSpan(0, 7, 30)));
            Beatles.AddTracks(new Track("Something", "John Lennon", new TimeSpan(0, 5, 34)));
            Beatles.AddTracks(new Track("Maxwell's Silver Hammer", "Paul Mccartney", new TimeSpan(0, 5, 34)));
            Beatles.AddTracks(new Track("Oh! Darling","", new TimeSpan(0, 3, 20)));
            Beatles.AddTracks(new Track ("Octopus's Darling", "John Lennon", new TimeSpan (0, 2, 10)));

        var Veto = new MusicCD ("VETO", "There's a Beat in All Machines", 190, 27-2-2006, "/Images/veto.jfif");

            Veto.AddTracks(new Track("Can you see anything", "Troels Abrahamsen", new TimeSpan(0, 3, 42)));
            Veto.AddTracks(new Track("We are not friends", "Troels Abrahamsen", new TimeSpan(0, 4, 12)));
            Veto.AddTracks(new Track("You Are a Knife", "VETO", new TimeSpan(0, 3, 32)));

            musiclist.Add(Beatles);
            musiclist.Add(Veto);
           
            ViewBag.musiclist = musiclist;
            ViewBag.books = books;
            ViewBag.Products = repository.Products;


            return View();
        }
    }
}