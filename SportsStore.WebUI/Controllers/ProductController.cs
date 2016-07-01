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
    public class ProductController : Controller
    {
        private IProductsRepository _productRepository;
        public int PageSize = 4;
        public ProductController(IProductsRepository productRepository)
        {
            _productRepository = productRepository;
        }



        // GET: Product
        public ActionResult List(string category, int page = 0)
        {
            var mdl = new ProductsListViewModel()
            {
                PagingInfo = new Models.PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = _productRepository.Products.Count()
                },
                Products = _productRepository.Products
                .Where(w => category == null || w.Category == category)
                .OrderBy(o => o.Id)
                .Skip(PageSize * page).Take(PageSize),
                CurrentCategory = category
            };
            return View(mdl);
            //  return View(_productRepository.Products.Skip(page * PageSize).Take(PageSize).OrderBy(s => s.Id));
        }
    }
}