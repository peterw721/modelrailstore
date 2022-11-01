using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _92031083_ModelRailStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id)
        {
            ViewBag.Message = "The Model Rail Store." + id;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Make Contact with Peter.";

            return View();
        }
    }
}