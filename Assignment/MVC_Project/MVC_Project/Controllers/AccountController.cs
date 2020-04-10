using MVC_Project.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Project.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserDetail userDetail)
        {
            try
            {
                using (var context = new MVCEntities())
                {
                    bool isValid = context.UserDetails.Any(x => x.UserName == userDetail.UserName && x.Password == userDetail.Password);
                    if (isValid)
                    {
                        FormsAuthentication.SetAuthCookie(userDetail.UserName, false);
                        return RedirectToAction("Form", "Employee");
                    }
                    ModelState.AddModelError("", "Ooops, InValid UserName or Password..........!!!!");
                }
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ActionResult SignUp()
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

        [HttpPost]
        public ActionResult SignUp(UserDetail userDetail)
        {
            try
            {
                using (var context = new MVCEntities())
                {
                    context.UserDetails.Add(userDetail);
                    context.SaveChanges();
                }
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ActionResult Logout()
        {
            try
            {
                FormsAuthentication.SignOut();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}