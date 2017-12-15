using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database;
using Database.Entities;
using Projekt.Models;

namespace Projekt.Controllers
{
    public class UserController : Controller 
    {
        
        private Repositories repositories;

        public UserController()
        {
            this.repositories = new Repositories();
        }


        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterUser(Register model)
        {
            if(!ModelState.IsValid) return View(model);
            {
                try
                {
                    var user = new User
                    {
                        Firstname = model.Firstname,
                        Lastname = model.Lastname,
                        Email = model.Email,
                        Password = model.Password

                    };

                    repositories.addUser(user);
                    repositories.saveUser();
                    return RedirectToAction("Login", "Login");
                }
                catch
                {
                    return View(model);
                }
            }
        }
    }   
}