using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BigPandaBakery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BigPandaBakery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            ViewData["Message"] = "The Menu page.";

            return View();
        }

        public IActionResult Order()
        {
            ViewData["Message"] = "The Order Online page.";

            return View();
        }

        public IActionResult ProductBread(int? id)
        {
            ViewData["Message"] = "The Product Bread page.";
            return View();
        }

        public IActionResult ProductTea(int? id)
        {
            ViewData["Message"] = "The Product Tea page.";

            return View();
        }

        public IActionResult ProductCake()
        {
            ViewData["Message"] = "The Product Cake page.";
            return View();
        }

        public IActionResult ProductDetails(int category, int? id)
        {
            ViewData["Message"] = "The Product Cake page.";
            if (category == 1) return ProductBread(id);
            else if (category == 2) return ProductTea(id);
            else return ProductCake();
        }

        public IActionResult ShowCart()
        {
            //ViewData["Message"] = "Show the Shopping Cart";
            HttpContext.Session.SetString("ShowCart", "showCart");
            return View("~/Views/Home/ProductCake.cshtml");
            //return RedirectToAction("ProductCake");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Cart()
        {
            ViewData["Message"] = "Your Shopping Cart page.";

            return View();
        }

        public IActionResult Checkout()
        {
            ViewData["Message"] = "Your checking out page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
