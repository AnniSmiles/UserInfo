using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInfo.Data.Models;
using UserInfo.Data.Services;

namespace UserInfo.Web.Controllers
{
    public class UsersController : Controller
    {
        IUserData db;

        public UsersController(IUserData db)
        {
            this.db = db;
        }
        // GET: Users
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            
            if(ModelState.IsValid)
            {
                db.Add(user);
                return RedirectToAction("Index");
            }
            return View();
           
        }

        
    }
}