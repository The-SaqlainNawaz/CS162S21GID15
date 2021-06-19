using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StartuppageController : Controller
    {
        // GET: Startuppage
        public ActionResult sigup()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult Customer()
        {
            return View();
        }

        public ActionResult ListofCustomers()
        {
            return View();
        }

    }
}