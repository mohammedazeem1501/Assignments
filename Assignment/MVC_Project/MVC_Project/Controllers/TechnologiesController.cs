using MVC_Project.Repository.Interface;
using MVC_Project.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class TechnologiesController : Controller
    {
        readonly IFrontend frontend;
        readonly IBackend backend;
        readonly IMobility mobility;
        readonly ITesting testing;

        public TechnologiesController()
        {
            frontend = new FrontendService();
            backend = new BackendService();
            mobility = new MobilityService();
            testing = new TestingService();
        }
        
      
        public ActionResult FrontEnd()
        {
            try
            {
                var get = frontend.GetDetails();
                ViewBag.data = get;
                return View(get);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public ActionResult BackEnd()
        {
            try
            {
                var get = backend.GetDetails();
                ViewBag.data = get;
                return View(get);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public ActionResult Mobility()
        {
            try
            {
                var get = mobility.GetDetails();
                ViewBag.data = get;
                return View(get);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public ActionResult Testing()
        {
            try
            {
                var get = testing.GetDetails();
                ViewBag.data = get;
                return View(get);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}