using IGI_6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace IGI_6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Client()
        {
            return View();
        }

        public ActionResult Furniture()
        {
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }

        public ActionResult Worker()
        {
            return View();
        }
    }
}