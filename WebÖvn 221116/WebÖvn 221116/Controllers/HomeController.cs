using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebÖvn_221116.Models;

namespace WebÖvn_221116.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RSVP()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVP(GuestResponse g)
        {
            //MVC använder Model Binding för att tolka datat från POST
            //till vad vi förväntar oss, dvs ett GuestResponse Object/entity
            //Modelbinding binder ihopp mappar, propertyn Name med värdet name.


            //Vi vill veta om svaret uppfyller modellens krav
            if (ModelState.IsValid == true)
            {
                return View("Thanks", g);

            }
            //Om inte valid, dvs namn saknas, visa formuläret igen
            return View();
        }
    }
}