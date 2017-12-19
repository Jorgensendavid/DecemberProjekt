using Database;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Database.Entities;

namespace Projekt.Controllers
{
    public class LoginController : Controller
    {
        private Repository repositories;

        public LoginController()
        {
            this.repositories = new Repository();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var user = repositories.GetPassword(model.Email, model.Password);
            

            if (user != null && user.Password == model.Password)
            {
                Session["UserId"] = user.UserID.ToString();
                return RedirectToAction("Profile", "Profile");
            }

            ModelState.AddModelError(nameof(model.Password), "Invalid password or username.");

            return View();
        }

        public ActionResult LoggOut()
        {
            Session.Abandon();
            Session.Remove("UserId");
            return View();
        }

       
    }
}