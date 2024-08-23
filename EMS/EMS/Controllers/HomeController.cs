using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            // Create a ContactViewModel with sample data or fetch from a service/database
            var contactModel = new ContactViewModel
            {
                CompanyName = "Infinite Computer Solutions",
                Address = "Chennai, Tamilnadu 98052-6399",
                Phone = "425.555.0100"
            };

            return View(contactModel);
        }
    }
}