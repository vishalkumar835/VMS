using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicalServiceApplication.Models;
using System.Web.Security;

namespace VehicalServiceApplication.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        //Login Details
        public ActionResult Login()   
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Member model)
        {
           using (var context = new VehicleCenterEntities())
            {
                bool isValid = context.UserLogins.Any(x => x.UName == model.UName && x.Password == model.Password);
                if(isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UName, false);
                    return RedirectToAction("Index","ServiceCenters");
                }
                ModelState.AddModelError("", "Invalid Username And Password ");
                return View();
            }
            
        }
        //signup Details
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(UserLogin model)
        {
            using(var context = new VehicleCenterEntities())
            {
                context.UserLogins.Add(model);
                context.SaveChanges();
            }
        
            return RedirectToAction("login"); //go to login page
        }

        public ActionResult Logout() // Logout the page
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}