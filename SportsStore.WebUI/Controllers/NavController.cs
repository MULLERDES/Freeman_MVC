using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class NavController : Controller
    {

        private IProductsRepository repository;

        public NavController(IProductsRepository repo)
        { repository = repo; }
        // GET: Nav
        public PartialViewResult Menu()
        {
            IEnumerable<string> catgs = repository.Products.Select(s => s.Category).Distinct().OrderBy(o => o);
            return PartialView(catgs);
        }
    }
}