using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New_ADM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "- NAD - 动画标签";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "欢迎各式各样的调戏.";

            return View();
        }
    }
}