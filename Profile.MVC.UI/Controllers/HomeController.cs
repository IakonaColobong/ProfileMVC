using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Profile.MVC.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //Commented out until I decide if a multi page app would be more appealing
        //public ActionResult GitHub()
        //{
        //    ViewBag.Message = "GitHub";
        //    return View();
        //}
        //public ActionResult CSharp()
        //{
        //    ViewBag.Message = "Text Adventure";
        //    return View();
        //}

        //public ActionResult StoreFront()
        //{
        //    ViewBag.Message = "Store Front";
        //    return View();
        //}
        //public ActionResult StaticHTML()
        //{
        //    ViewBag.Message = "HTML/CSS Only site";
        //    return View();
        //}

        //public ActionResult Portfolio()
        //{
        //    ViewBag.Message = "Project Portfolio";
        //    return View();
        //}


    }
}