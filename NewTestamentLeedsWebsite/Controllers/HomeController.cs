using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewTestamentLeedsWebsite.Models;

namespace NewTestamentLeedsWebsite.Controllers
{
    public class HomeController : Controller
    {
        private INTCGLeedsContext siteContext;
        
        public HomeController()
        {
            siteContext = new NTCGLeedsContext();
        }

        public HomeController(INTCGLeedsContext injectionContext)
        {
            siteContext = injectionContext;
        }
        
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult _FeaturedEvents(int mobile = 0)
        {
            List<CEvent> events;
            ViewBag.Mobile = mobile;

            events = (from evt in siteContext.CEvents
                      where evt.startDisplayDate <= DateTime.Now && evt.endDisplayDate >= DateTime.Now
                      select evt).ToList();

            return PartialView("_FeaturedEvents", events);
        }
    }
}
