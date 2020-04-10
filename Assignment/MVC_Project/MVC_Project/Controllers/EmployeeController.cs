using MVC_Project.Filters;
using MVC_Project.Models.EntityModels;
using MVC_Project.Repository.Interface;
using MVC_Project.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    [Authorize(Order = 1)]
    [RoutePrefix("Employee")]
    public class EmployeeController : Controller
    {

        readonly IEmployee employeeService;
        private MVCEntities db = new MVCEntities();
        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }
        [Route("Form")]
        public ActionResult Form()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [Route("Form")]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Form(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int id = employeeService.AddEmployee(employee);
                    if (id > 0)
                    {
                        ModelState.Clear();
                        return RedirectToAction("View_Form");
                    }
                }
                return View(employee);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [Route("")]
        [HttpGet]          
        public ActionResult View_Form()
        {
            try
            {
                var get = employeeService.GetEmployee();
                return View(get);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HandleError(Order =3)]
        [OutputCache (Duration =60 , Order =2)]
        [Route("One")]
        public ActionResult One()
        {
            return View();
        }
        [MyException]
        [Route("MyError")]
        public ActionResult MyError()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [Route("Two")]
        public ActionResult Two()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [Route("Three")]
        public ActionResult Three()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [Route("Four")]
        public ActionResult Four()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [Route("Five")]
        public ActionResult Five()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [Route("{id}")]
        public ActionResult Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Employee employee = db.Employees.Find(id);
                if (employee == null)
                {
                    return HttpNotFound();
                }
                return View(employee);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

}