using WebLinhkien.Models;
using WebLinhkien.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebLinhkien.Controllers
{
    public class ContactController : Controller
    {
        ShopDatabaseContext db = new ShopDatabaseContext();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult Index(ContactViewModel contacts)
        {
            try
            {
                if (ModelState.IsValid)
                {                
                        var user = new Feedback();
                        user.Name = contacts.Name;
                        user.Phone = contacts.Phone;
                        user.address = contacts.address;
                        user.Content = contacts.Content;
                        user.Createdate = DateTime.Now;
                        user.email = contacts.email;
                        user.status = false;

                        var result = db.Feedbacks.Add(user);
                        db.SaveChanges();

                        //var result = db.Entry(register).State = EntityState.Added;
                        //db.SaveChanges();
                        if (result != null)
                        {
                            ViewBag.Success = "Đã gửi thông tin! chúng tôi sẽ phản hồi qua email";
                            ModelState.Clear();
                        }
                        else
                        {
                            ModelState.AddModelError("", "Đăng kí không thành công");
                        }
            
                }
            }


            catch (Exception ex)
            {

            }
            //return RedirectToAction("Login", "Login");
            return View(contacts);
      
        }
        public ActionResult News(int? id)
        {
            try
            {
                ViewBag.home = (from p in db.Blogs orderby Guid.NewGuid() select p).ToList();
            }
            catch { }
            return View();
        }
           public ActionResult DetailBlogs(int? id)
        {
            try
            {
                var model = db.Blogs.Find(id); //linq tim id
                db.SaveChanges();
                return View(model);
            }
            catch
            {
                
            }
            return View();
        }

          
           
        }
    }
