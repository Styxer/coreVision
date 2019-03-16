using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using coreVision.Models;
using ExportCSV;

namespace coreVision.Controllers
{
    public class UserController : Controller
    {
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
                using (dbModels dbModel = new dbModels())
                {
                    try
                    {
                        //throw new Exception();
                        dbModel.landingPages.Add(landingPage);
                        dbModel.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        ViewBag.DangerMessage = "an error happened";
                        return View("Add", landingPage);
                    }
                }
                ModelState.Clear();
                ViewBag.SuccessMessage = "you message was sent successfully"; 
            }
            return View(landingPage);
        }

        public ActionResult ExportToCSV()
        {
            using (dbModels dbModel = new dbModels())
            {
                var entriesList = new List<landingPage>();
                foreach (var data in dbModel.landingPages)
                {
                    entriesList.Add(data);
                }
               var  objProcessDocument = new ProcessDocument<landingPage>();
              // var outputString = String.Empty;
              objProcessDocument.ExportToCsv(entriesList, out string outputString, HttpContext);
            }
            return Content("");
        }

    }
}