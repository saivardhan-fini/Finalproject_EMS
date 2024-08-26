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
            var contactModel = new ContactViewModel
            {
                CompanyName = "Infinite Computer Solutions",
                Addresses = new List<Address>
                {
                    new Address
                    {
                        Street = "MEPZ",
                        City = "Chennai",
                        State = "Tamilnadu",
                        ZipCode = "98052-6399",
                        PhoneNumber = "425.555.0101"
                    },
                    new Address
                    {
                        Street = "Perkit Road",
                        City = "Hyderabad",
                        State = "Telangana",
                        ZipCode = "503224",
                        PhoneNumber = "425.555.0102"
                    },
                    new Address
                    {
                        Street = "EPIP Zone Whitefield Rd",
                        City = "Bangalore",
                        State = "Karnataka",
                        ZipCode = "98054-6399",
                        PhoneNumber = "425.555.0103"
                    },

                    new Address
                    {
                        Street = "Noida Main A-block",
                        City = "Noida",
                        State = "UttarPradesh",
                        ZipCode = "98054-7899",
                        PhoneNumber = "425.666.9999"

                    }
                }

                };

            return View(contactModel);
        }
    }
}
