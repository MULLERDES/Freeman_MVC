using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.ViewModels;

namespace SportsStore.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductsRepository repository;

        public CartController(IProductsRepository repo)
        {
            repository = repo;
        }
        
        public RedirectToRouteResult AddToCart(int Id, string returnUrl)
        {
            var product = repository.Products.FirstOrDefault(f => f.Id == Id);
            if(product != null)
                CartInSession.AddItem(product,1);
            return RedirectToAction("Index", new { returnUrl });
        }

        public ActionResult Index(Cart cart,string returnUrl)
        {
            return View(new CartInfoViewModel() {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }


        private Cart CartInSession
        {
            get
            {
                var cart = (Cart)Session[nameof(Cart)];
                if (cart ==null)
                {
                    cart = new Cart();
                    Session[nameof(Cart)] = cart;
                }
                return cart;
            }
        }
    }
}