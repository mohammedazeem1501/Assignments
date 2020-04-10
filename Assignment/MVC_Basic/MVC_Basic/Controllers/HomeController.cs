using MVC_Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basic.Controllers
{
    public class HomeController : Controller
    {
        readonly IStudent _student;

        public HomeController()
        {
            _student = new StudentService();
        }

        // GET: Home
        public ActionResult Index()
        {
            // In this View , I have set the Main_layout so that my header and navbar is inserted on this Home/Index page
            // In this I have used Html.Render and Html.RenderPartial
            return View();
        }
        public ActionResult One()
        {
           
            return View();
        }
        public PartialViewResult OneSubpart()
        {
            return PartialView("_PartialView");
        }
        public ActionResult Two()
        {
            return View();
        }
        [NonAction]
        public PartialViewResult NonAction() // it will not be executed anywhere.
        {
            return PartialView("_PartialView");
        }
        [ChildActionOnly]
        public PartialViewResult ChildAction() // this method will be invoked inside any other action
        {                                      // and it cannot be created directly as /home/childaction    
            return PartialView("_PartialView");
        }
        public ActionResult Three()
        {
            return View();
        }

       [HttpGet]
        public ActionResult GetStudent()
        {
            var result = GetStudentList();
            return View("GetStudent",result);
        }
        public IEnumerable<Student> GetStudentList()
        {
            var result = _student.GetStudent();
            return result;
        }

        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form([Bind(Include = "Roll_No,Name,Address")] Student student)
        {                               // this method shows the binding of the 
            if (ModelState.IsValid)
            {
                _student.Save(student);
                return RedirectToAction("GetStudent");
            }
            return View("Form");
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