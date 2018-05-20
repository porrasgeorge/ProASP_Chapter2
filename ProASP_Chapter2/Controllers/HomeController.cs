using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProASP_Chapter2.Models;

namespace ProASP_Chapter2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.hour = DateTime.Now.Hour;
            ViewBag.minute = DateTime.Now.Minute;
            ViewBag.secs = DateTime.Now.Second;
            return View();
        }

        [HttpGet]
        public ViewResult RegisterForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RegisterForm(ResponseModel rm)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", rm);
            }
            else
            {
                return View();
            }
            
        }

        public ViewResult RegisterForm2()
        {
            return View();
        }
    }
}