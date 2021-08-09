using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}