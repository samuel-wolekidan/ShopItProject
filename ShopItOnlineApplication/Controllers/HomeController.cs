using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopItOnlineApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ShopIt!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What You Want To Know About ShopIt!";

            return View();
        }

		public ActionResult Contact()
        {
            ViewBag.Message = "Here is our contact information. ShopIt! :)";

            return View();
        }
    }
}
