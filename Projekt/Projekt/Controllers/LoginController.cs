using Database;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt.Controllers
{
    public class LoginController : Controller
    {
        private Repositories repositories;

        public LoginController()
        {
            this.repositories = new Repositories();
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
            try
            {
                var emailInput = model.Email;
                var passwordInput = model.Password;
                var dBpassword = repositories.GetPassword(model.Email, model.Password);
                if (passwordInput == dBpassword.Password)
                {
                    return RedirectToAction("About", "Home");
                }

                return View(model);
            }
            catch
            {
                return View(model);
            }
        }
    }
}