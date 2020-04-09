using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Introduction.Controllers
{
    public class ValueController : Controller
    {
        // GET: Value
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.MyKey = TempData["Data"];
            return View();
        }
    }
}