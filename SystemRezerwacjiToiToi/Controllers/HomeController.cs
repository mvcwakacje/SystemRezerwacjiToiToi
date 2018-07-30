using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemRezerwacjiToiToi.Models.Repos;

namespace SystemRezerwacjiToiToi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new RepoForHome();
            return View(model.GetOne(1));
        }

        public ActionResult FullOption()
        {
            ViewBag.M = "Info";
            var model = new RepoForHome();
            return View(model.GetAll());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}