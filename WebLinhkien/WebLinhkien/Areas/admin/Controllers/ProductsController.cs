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
{[Authorize(Roles ="Admin")]
    public class ProductsController : Controller
    {
        private ShopDatabaseContext db = new ShopDatabaseContext();

        // GET: admin/Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: admin/Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // GET: admin/Products/Create
        public ActionResult Create()
        {
            ViewBag.IDSupp = new SelectList(db.Suppliers, "ID", "Name");
            ViewBag.IDCate = new SelectList(db.Categories, "ID", "Name");
            return View();
        }

        // POST: admin/Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Product_Code,Name,Descriptions,Parameter,Quanlity,Price,Hot,viewcount")] Products products, HttpPostedFileBase Uploadimg)
        {
           if (ModelState.IsValid)
            {
                ViewBag.IDSupp = new SelectList(db.Suppliers, "ID", "Name");
                ViewBag.IDCate = new SelectList(db.Categories, "ID", "Name");
                products.Createdates = DateTime.Now;
                products.viewcount = 0;
      
                if (Uploadimg != null && Uploadimg.ContentLength > 0)
                {
                    if (Uploadimg.ContentType == "image/jpg" || Uploadimg.ContentType == "image/png" || Uploadimg.ContentType == "image/jpeg" || Uploadimg.ContentType == "image/gif")
                    {
                        Uploadimg.SaveAs(Server.MapPath("~/Content/img/") + Uploadimg.FileName);
                        products.Image = Uploadimg.FileName;
                    }
                    else
                        return View();
                }
                else { return View(); }
                db.Products.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(products);
        }

        // GET: admin/Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // POST: admin/Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Product_Code,Name,Descriptions,Parameter,Quanlity,Price,Hot,viewcount")] Products products,HttpPostedFileBase Uploadimg)
        {
            if (ModelState.IsValid)
            {
                ViewBag.IDSupp = new SelectList(db.Suppliers, "ID", "Name");
                ViewBag.IDCate = new SelectList(db.Categories, "ID", "Name");
                products.Datesupdate = DateTime.Now;
                products.viewcount = 0;

                if (Uploadimg != null && Uploadimg.ContentLength > 0)
                {
                    if (Uploadimg.ContentType == "image/jpg" || Uploadimg.ContentType == "image/png" || Uploadimg.ContentType == "image/jpeg")
                    {
                        Uploadimg.SaveAs(Server.MapPath("~/Content/img/") + Uploadimg.FileName);
                        products.Image = Uploadimg.FileName;
                    }
                    else
                        return View();
                }
                else { return View(); }
                db.Entry(products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(products);
        }

        // GET: admin/Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // POST: admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Products products = db.Products.Find(id);
            db.Products.Remove(products);
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
