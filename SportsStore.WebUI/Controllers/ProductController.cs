﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

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
        public ActionResult List(int page = 1)
        {
            return View(_productRepository.Products.Skip(page*PageSize).Take(PageSize).OrderBy(s=>s.Id));
        }
    }
}