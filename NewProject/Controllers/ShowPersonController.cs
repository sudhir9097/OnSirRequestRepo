using NewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewProject.Controllers
{
    public class ShowPersonController : Controller
    {
        // GET: ShowPerson
        public ActionResult Index()
        {
            List<First> persons = new List<First>()
    {
        new First { FirstName = "Sherlock", LastName = "Holmes" },
        new First { FirstName = "James", LastName = "Watson" }
    };
            return View(persons);
        }
    }
}