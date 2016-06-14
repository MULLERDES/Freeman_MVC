using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WARSVP.Models;

namespace WARSVP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int h = DateTime.Now.Hour;
            ViewBag.Greeting = h < 12 ? "Good morning" : "Good afrernoon"; 
            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse model)
        {
            if (ModelState.IsValid)
            return View("Thanks", model);
            return View(model);
        }
    }
}