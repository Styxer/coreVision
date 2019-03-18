using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using coreVision.DAL;
using coreVision.Models;
using ExportCSV;

namespace coreVision.Controllers
{
    public class UserController : Controller
    {
        private ILandingPageRepositiry landingPageRepositiry;

        public UserController()
        {
            this.landingPageRepositiry = new LandingPageRepositroy(new dbModels());
        }

        public UserController(ILandingPageRepositiry landingPageRepositiry)
        {
            this.landingPageRepositiry = landingPageRepositiry;
        }


        [HttpGet]
        public ActionResult Add(int id = 0)
        {
            landingPage landingPage = new landingPage();
            return View(landingPage);
        }

        [HttpPost]
        public ActionResult Add(landingPage landingPage)
        {
            if (ModelState.IsValid)
            {            
                try
                {            
                    landingPageRepositiry.InsertData(landingPage);
                    landingPageRepositiry.Save();
                }
                catch (Exception ex)
                {

                    ViewBag.DangerMessage = "an error happened";
                    return View("Add", landingPage);
                }
             
                ModelState.Clear();
                ViewBag.SuccessMessage = "you message was sent successfully"; 
            }
            return View(landingPage);
        }

        public ActionResult ExportToCSV()
        {        
              var  objProcessDocument = new ProcessDocument<landingPage>();
           
              objProcessDocument.ExportToCsv(landingPageRepositiry.getData().ToList(), out string outputString, HttpContext);
       
            return Content("");
        }

    }
}