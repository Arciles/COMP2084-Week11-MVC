using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week10.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Browse()
        {
            var songs = new String[] { "You shook me", "King of pain", "City of Blinding Lights" };
            ViewBag.Songs = songs;
            return View();
        }
    }
}