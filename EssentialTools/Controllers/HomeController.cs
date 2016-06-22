using EssentialTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ET.Abstraction;
using Ninject;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products =
            {
            new Product { Name = "Kayak", Category = "Watersports", Price = 275M },
            new Product { Name = "Lifejacket", Category = "Watersports", Price = 48.95M },
            new Product { Name = "Soccer ball", Category = "Soccer", Price = 19.50M },
            new Product { Name = "Corner flag", Category = "Soccer", Price = 34.95M }
        };

        private ILinqValueCalculator calc;
        public HomeController(ILinqValueCalculator c)
        {
            calc = c;

        }
        // GET: Home
        public ActionResult Index()
        {
            //IKernel ninjectKErnel = new StandardKernel();
            //ninjectKErnel.Bind<ILinqValueCalculator>().To<LinqValueCalculator>();

           //ILinqValueCalculator calc = ninjectKErnel.Get<ILinqValueCalculator>();
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalVAlue = cart.CalculateProductTotal();
            return View(totalVAlue);
        }
    }
}