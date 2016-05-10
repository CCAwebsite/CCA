using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CCA.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Newsletters()
        {
            return View();
        }
        public ActionResult IntheNews()
        {
            return View();
        }
        public ActionResult Alumni()
        {
            return View();
        }
    }
}