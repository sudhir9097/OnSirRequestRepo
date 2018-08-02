using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemoProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(int input1,int input2)
        {
            ViewBag.Name = "hello user";
            return View(ViewBag);
        }
    }
}