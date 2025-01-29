using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Basico.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tu Biblioteca Web.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contactame Aqui!";

            return View();
        }
    }
}