using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WACH5.Models;

namespace WACH5.Controllers
{
    public class HomeController : Controller
    {

        Product _myProduct = new Product()
        {
            Category = "tcat",
            Description = "tdescr",
            Id = 1,
            Name = "tname",
            Price = 1234.23M
        };
        // GET: Home
        public ActionResult Index()
        {
            return View(_myProduct);
        }
        public ActionResult NameAndPrice()
        {
            return View(_myProduct);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;
            return View(_myProduct);
        }
    }
}