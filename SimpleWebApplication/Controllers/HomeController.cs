using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database;
using Database.Model;
using SimpleWebApplication.Services;

namespace SimpleWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService service;

        public HomeController(IMessageService service)

        {
            this.service = service; 
        }

        public ActionResult Index()
        {
            using (var context = new BreakAwayContext())
            {
                Destination destination = new Destination();
                destination.Country = "Canada1";
                destination.Name = "HotelInn1";
                Lodging lodgingFirst = new Lodging();
                lodgingFirst.Name = "Suhail1";
                lodgingFirst.Owner = "Khan1";
                lodgingFirst.IsResort = true;
                destination.Lodgings.Add(lodgingFirst);
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = service.GetWelcomeMessage();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}