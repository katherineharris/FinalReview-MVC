using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudyGuide.Models;

namespace StudyGuide.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            List<About> a = new List<About>();
            About ab = new About();
            {
                ab.Coach = "Lincoln Riley";
                ab.BowlRecord = "29-22-1 (.567)";
                ab.NationalTitle = "7 (1950, 1955, 1956, 1974, 1975, 1985, 2000)";
            }
            a.Add(ab);
            return View(a);
        }
    }
}