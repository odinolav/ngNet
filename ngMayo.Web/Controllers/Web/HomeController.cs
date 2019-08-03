using System;
using System.Web.Mvc;

namespace ngNet.Web.Controllers.Web
{
    public class HomeController : BaseController
    {
        public HomeController() { }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public void Throw()
        {
            throw new ArgumentException("this failed");
        }
    }
}
