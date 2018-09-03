using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mentors()
        {
            ViewBag.Message = "Mentor page.";

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = "Team page.";

            return View();
        }
        
        public ActionResult Meetings()
        {
            ViewBag.Message = "Meeting page";
            return View();
        }

        public ActionResult Milestones()
        {
            ViewBag.Message = "Milestones achieved";
            return View();
        }

        public ActionResult Videos()
        {
            ViewBag.Message = "UHCL/project vidoes";
            return View();
        }


    }
}