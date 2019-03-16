using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coreVision.Models;

namespace coreVision.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Add(int id = 0)
        {
            LandingPage landingPage = new LandingPage();
            return View(landingPage);
        }

        [HttpPost]
        public ActionResult Add(LandingPage landingPage)
        {

            return View("Add", new LandingPage());
        }
    }
}