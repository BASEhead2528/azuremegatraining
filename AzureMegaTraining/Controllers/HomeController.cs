using AzureMegaTraining.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AzureMegaTraining.Controllers
{
    public class HomeController : Controller
    {
        private DBContext db = new DBContext();


        public ActionResult Index()
        {
            var temp = System.Web.HttpContext.Current.User.Identity.GetUserId();
            var temp2 = HttpContext;
            var temp3 = Membership.GetUser();
            var temp4 = HttpContext.User.Identity.GetUserId();
            var temp5 = HttpContext.User.Identity.IsAuthenticated;

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
    }
}