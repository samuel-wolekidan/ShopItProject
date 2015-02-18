using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopItOnlineApplication.Models;

namespace ShopItOnlineApplication.Controllers
{
    public class CartController : Controller
    {
        //b
        // GET: /Cart/

        public ActionResult Index()
        {
            CartItem cartItem = new CartItem() { };
            return View(cartItem);
        }

    }
}
