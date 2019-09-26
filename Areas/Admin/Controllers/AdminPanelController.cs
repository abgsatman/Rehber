using Rehber.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rehber.Areas.Admin.Controllers
{
    public class AdminPanelController : Controller
    {
        // GET: Admin/AdminPanel
        public ActionResult Index()
        {
            return View();
        }

        UsersDBEntities UserDB = new UsersDBEntities();

        public ActionResult GetUserList()
        {
            var model = UserDB.Users.ToList();

            return View(model);
        }
    }
}