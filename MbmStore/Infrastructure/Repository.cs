using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;

namespace MbmStore.Infrastructure
{
    public static class repository
    {
      
        

        
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();

        static repository() {
            //objects
            //Music
            var Beatles = new MusicCD("Beatles", "Abbey Road", 125, 26 - 9 - 1969, "/Images/abbey.jfif");

            Beatles.AddTracks(new Track("Come together", "John Lennon", new TimeSpan(0, 7, 30)));
            Beatles.AddTracks(new Track("Something", "John Lennon", new TimeSpan(0, 5, 34)));
            Beatles.AddTracks(new Track("Maxwell's Silver Hammer", "Paul Mccartney", new TimeSpan(0, 5, 34)));
            Beatles.AddTracks(new Track("Oh! Darling", "", new TimeSpan(0, 3, 20)));
            Beatles.AddTracks(new Track("Octopus's Darling", "John Lennon", new TimeSpan(0, 2, 10)));

            var Veto = new MusicCD("VETO", "There's a Beat in All Machines", 190, 27 - 2 - 2006, "/Images/veto.jfif");

            Veto.AddTracks(new Track("Can you see anything", "Troels Abrahamsen", new TimeSpan(0, 3, 42)));
            Veto.AddTracks(new Track("We are not friends", "Troels Abrahamsen", new TimeSpan(0, 4, 12)));
            Veto.AddTracks(new Track("You Are a Knife", "VETO", new TimeSpan(0, 3, 32)));

            //books
            Book b1 = new Book("Stanley Kubrick", "The Shining", 150, 28 - 1 - 1977, "/Images/shining.jfif");
            Book b2 = new Book("Gud", "Biblen", 250, 0 - 0 - 0, "/Images/bible.jfif");

            //Movies
            // create a new Movie object with instance name jungleBook
            var jungle = new Movie("Jungle Book", 160.50m, "/Images/junglebook.jpg", "Jon Favreau");

            // assign a ViewBag property to the new Movie object


            // create a new Movie object with instance name jungleBook
            var gladiator = new Movie("Gladiator", 160.50m, "/Images/gladiator.jpg", "Ridley Scott");

            var forrestgump = new Movie("Forrest Gump", 160.50m, "/Images/forrest-gump.jpg", "Rasmus Haahr");
            // assign a ViewBag property to the new Movie object

            Products.Add(Beatles);
            Products.Add(Veto);
            Products.Add(b1);
            Products.Add(b2);
            Products.Add(jungle);
            Products.Add(gladiator);
            Products.Add(forrestgump);

            //custumers 
            var Custumer1 = new Custumer("Søren", "N", "Helvedes Kerne 666", "6666", "Hell");
            
       
            var Custumer2 = new Custumer("Jesus", "Christ", "Heaven road 888", "420", "Sky");
       
            var Custumer3 = new Custumer("Leif", "Dahlgaard", "Ingen fast Adresse", "0000", "Frederiks");

            //Orderitems
            var Order1 = new OrderItem(jungle, 2);
            var Order2 = new OrderItem(Veto, 1);
            var Order3 = new OrderItem(gladiator, 3);
            var Order4 = new OrderItem(Beatles, 2);

            //Invoices

           var I1 = new Invoice(1, DateTime.Now, Custumer1);
           I1.AddOrderItems(Order1);
           I1.AddOrderItems(Order2);
            var I2 = new Invoice(2, DateTime.Now, Custumer2);
            I2.AddOrderItems(Order3);
            I2.AddOrderItems(Order4);

            Invoices.Add(I1);
            Invoices.Add(I2);

        }
    }
}

