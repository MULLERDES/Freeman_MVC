using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.ViewModels
{
    public class CartInfoViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}