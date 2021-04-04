using Portfolio.Data;
using Portfolio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        PortfolioDBContext db = new PortfolioDBContext();
        public ActionResult Index()
        {
            List<Project> p = new List<Project>();
            p = db.Projects.Include("Company").ToList();
            return View(p);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}