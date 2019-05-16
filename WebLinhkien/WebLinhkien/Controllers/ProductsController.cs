using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Sql;
using WebLinhkien.Models;
using WebLinhkien.ViewModels;
using System.Net;

namespace WebLinhkien.Controllers
{
    public class ProductsController : Controller
    {
        ShopDatabaseContext db = new ShopDatabaseContext();
        // GET: Products
        public ActionResult Category(int? CategoryID = 0)
        {
            try { 


            if (CategoryID != 0)
                {

                    //string a = db.Categories.SingleOrDefault(p => p.Name != null).Name;
                    string a = (from item in db.Categories
                                where item.ID == CategoryID
                                select item.Name).FirstOrDefault();
                    ViewBag.tieude = a;
                    var model = db.Products.Where(p => p.Categories.ID == CategoryID).ToList();

                    return View(model);
                }
            }
            catch { }
            return View();
        }
        public ActionResult Detail(int? id)
        {
            
            var model = db.Products.Find(id); //linq tim id
            model.viewcount++;//tim thay id thi + 1
            db.SaveChanges();

            // Lấy cookie cũ tên views
            var views = Request.Cookies["views"];
            // Nếu chưa có cookie cũ -> tạo mới
            if (views == null)
            {
                views = new HttpCookie("views");
            }
            // Bổ sung mặt hàng đã xem vào cookie
            views.Values[id.ToString()] = id.ToString();
            // Đặt thời hạn tồn tại của cookie
            views.Expires = DateTime.Now.AddMonths(1);
            // Gửi cookie về client để lưu lại
            Response.Cookies.Add(views);

            // Lấy List<int> chứa mã hàng đã xem từ cookie
            var keys = views.Values
                .AllKeys.Select(k => int.Parse(k)).ToList();
            // Truy vấn háng đãn xem
            ViewBag.Views = db.Products
                .Where(p => keys.Contains(p.ID));

            return View(model);


        }
        public ActionResult Search(String SupplierId = "", int CategoryId = 0, String Keywords = "")
        {
            if (SupplierId != "")
            {
                var model = db.Products
                    .Where(p => p.Suppliers.Name == SupplierId);
                return View(model);
            }
            else if (CategoryId != 0)
            {
                var model = db.Products
                    .Where(p => p.Categories.ID == CategoryId);
                return View(model);
            }
         
            else if (Keywords != "")
            {
                var model = db.Products
                    .Where(p => p.Name.Contains(Keywords) || p.Product_Code.Contains(Keywords));
                return View(model);
            }
            
            return View(db.Products);
        }
       
    }
}