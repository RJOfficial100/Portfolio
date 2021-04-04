using Portfolio.Data;
using Portfolio.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private PortfolioDBContext db = new PortfolioDBContext();

        // GET: Projects
        //used
        public ActionResult Index()
        {
            var projects = db.Companies.Include(p=>p.Projects);
            return View(projects.ToList());
        }

        // GET: Projects/Details/5
        //used
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Include(c => c.Company).Where(x => x.ProjectId == id).FirstOrDefault();
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "CompanyName");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectId,ProjectName,StartMonth,EndMonth,StartYear,EndYear,Current,ProjectDescription,TechnologiesUsed,Role,CompanyId")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "CompanyName", project.CompanyId);
            return View(project);
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "CompanyName", project.CompanyId);
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectId,ProjectName,StartMonth,EndMonth,StartYear,EndYear,Current,ProjectDescription,TechnologiesUsed,Role,CompanyId")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "CompanyName", project.CompanyId);
            return View(project);
        }

        // GET: Projects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = db.Projects.Find(id);
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public PartialViewResult ShowProjects(int id)
        {
            List<Company> companies= new List<Company>();
            if(id==0)
            {
                companies = db.Companies.Include(p => p.Projects).ToList();
                return PartialView("_ShowProject", companies);
            }
            else
            {
                companies = db.Companies.Where(x => x.CompanyId == id).Include(p => p.Projects).ToList();
            }
            return PartialView("_ShowProject", companies);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
