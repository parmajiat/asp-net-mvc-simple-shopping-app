using Parmajiat.Shopping.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parmajiat.Shopping.Controllers
{
    public class HomeController : Controller
    {
        DataRepository repo = new DataRepository();
        public ActionResult Index()
        {            
            return View(DataRepository.products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}