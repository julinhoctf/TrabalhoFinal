using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Musicas! Musicas! MMMMMMMMMUUUUUUUSSSSSIIICCAS.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Email: julio.trindade@catolicasc.org.br";

            return View();
        }
    }
}