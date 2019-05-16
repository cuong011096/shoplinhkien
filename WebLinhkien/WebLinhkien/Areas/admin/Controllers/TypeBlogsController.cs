using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebLinhkien.Models;

namespace WebLinhkien.Areas.admin.Controllers
{
    public class TypeBlogsController : Controller
    {
        private ShopDatabaseContext db = new ShopDatabaseContext();

        // GET: admin/TypeBlogs
        public ActionResult Index()
        {
            return View(db.typeBlogs.ToList());
        }

        // GET: admin/TypeBlogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeBlog typeBlog = db.typeBlogs.Find(id);
            if (typeBlog == null)
            {
                return HttpNotFound();
            }
            return View(typeBlog);
        }

        // GET: admin/TypeBlogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/TypeBlogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Type")] TypeBlog typeBlog)
        {
            if (ModelState.IsValid)
            {
                db.typeBlogs.Add(typeBlog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeBlog);
        }

        // GET: admin/TypeBlogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeBlog typeBlog = db.typeBlogs.Find(id);
            if (typeBlog == null)
            {
                return HttpNotFound();
            }
            return View(typeBlog);
        }

        // POST: admin/TypeBlogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Type")] TypeBlog typeBlog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeBlog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeBlog);
        }

        // GET: admin/TypeBlogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeBlog typeBlog = db.typeBlogs.Find(id);
            if (typeBlog == null)
            {
                return HttpNotFound();
            }
            return View(typeBlog);
        }

        // POST: admin/TypeBlogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeBlog typeBlog = db.typeBlogs.Find(id);
            db.typeBlogs.Remove(typeBlog);
            db.SaveChanges();
            return RedirectToAction("Index");
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
