using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Introduction.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Name = "This string is coming from Controller to View using ViewBag";
            ViewBag.Property = "Below is a List of Names (using ViewData) : ";
            ViewData["MyList"] = new List<string>() {"Azeem","Suraj","Himanshu","Gaurav" };
            TempData["Data"] = "Data from Home Controler to Value Controller using Temp Data";


            return View();
        }

        [HttpPost]
        public string UsingParameters(string Firstname, string Lastname)
        {
            try
            {
                return "From parameters : " + Firstname + " , " + Lastname;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public string UsingRequest()
        {
            try
            {
                string first = Request["Firstname"];
                string last = Request["Lastname"];
                return "From request : " + first + " , " + last;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPost]
        public string UsingFormCollection(FormCollection formCollection)
        {
            try
            {
                string first = formCollection["Firstname"];
                string last = formCollection["Lastname"];
                return "From form collection : " + first + " , " + last;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ActionResult One()
        {
            return View();
        }
        public ActionResult Two()
        {
            return View();
        }
        public ActionResult Four()
        {
            return View();
        }
        public ActionResult Five()
        {
            return View();
        }
    }
}