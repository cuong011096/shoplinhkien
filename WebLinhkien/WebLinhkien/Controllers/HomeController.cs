using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using WebLinhkien.Models;

namespace WebLinhkien.Controllers
{
    public class HomeController : Controller
    {
        ShopDatabaseContext db = new ShopDatabaseContext();
 
        public ActionResult Index()
        {
            var model = db.Categories
                 .Where(c => c.Products.Count >= 4)
                 .OrderBy(c => Guid.NewGuid()).ToList();
            int thu = model.Count;
            return View(model);
        }
        public ActionResult Category()
        {
            var model = db.Categories;
            return PartialView("_Category", model);
        }
        [ChildActionOnly]
        public ActionResult Carouse()
        {
            var baselineDate = DateTime.Now.AddDays(-7);
            var products = db.Products.Where(x => x.Createdates > baselineDate).OrderByDescending(x => x.ID).Take(6).ToList();
           
            return PartialView("_Carouse", products);
        }
       
    }
}