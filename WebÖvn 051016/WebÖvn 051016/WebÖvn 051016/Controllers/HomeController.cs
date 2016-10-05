using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebÖvn_051016.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello from the MVC Controller and Action Method Index()";
        //}


        //GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}