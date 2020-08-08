using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDH.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult OrdersList()
        {
            return View();
        }
        public ActionResult OrderConfirmation()
        {
            return View();
        }
        public ActionResult OrderInformation()
        {
            return View();
        }
        public ActionResult ShipmentDetails()
        {
            return View();
        }
    }
}