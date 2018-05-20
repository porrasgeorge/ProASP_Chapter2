using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProASP_Chapter2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult RegisterForm()
        {
            return View();
        }

        public ViewResult RegisterForm2()
        {
            return View();
        }
    }
}