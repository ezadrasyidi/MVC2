using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldMVC.Models;

namespace HelloWorldMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult addPerson(string name, int yob)
        {
            Person p = new Person(name, yob);
            p.calculateAge();
            return View(p);
        }

        [ActionName("Optional")]
        public ActionResult addPerson()
        {
            Person p = new Person("Adib", 1996);
            p.calculateAge();
            return View(p);
        }
    }
}