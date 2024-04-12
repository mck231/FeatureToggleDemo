using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeatureToggleDemo.Attribute;

namespace FeatureToggleDemo.Controllers
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

        [FeatureToggle("AdvancedFeature", "Admin", "SuperUser")]
        public ActionResult FeatureToggle()
        {
            // Your existing code here

            bool isFeatureEnabled = true;
            string message = isFeatureEnabled ? "The feature is enabled for the user." : "The feature is disabled for the user.";

            return Json(new { message = message }, JsonRequestBehavior.AllowGet);
        }
    }
}