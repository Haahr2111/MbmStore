using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustumerController : Controller
    {
        public IActionResult Index()
        {
            List<Custumer> custumers = new List<Custumer>();
            
            var Custumer1 = new Custumer("Søren", "N", "Helvedes Kerne 666", "6666", "Hell");
            Custumer1.AddPhone("91243454");
            Custumer1.AddPhone("21245432");
            Custumer1.Birthdate= new DateTime(1994, 2, 12); 
            var Custumer2 = new Custumer("Jesus", "Christ", "Heaven road 888", "420", "Sky");
            Custumer2.AddPhone("12832912");
            Custumer2.AddPhone("90823712");
            Custumer2.Birthdate = new DateTime(1992, 11, 12);
            var Custumer3 = new Custumer("Leif", "Dahlgaard", "Ingen fast Adresse", "0000", "Frederiks");
            Custumer3.AddPhone("90128312");
            Custumer3.AddPhone("12039231");
            Custumer3.Birthdate = new DateTime(1992, 11, 12);



            custumers.Add(Custumer1);
            custumers.Add(Custumer2);
            custumers.Add(Custumer3);

            
            ViewBag.custumers = custumers;
            return View();
        }

    }
     
}