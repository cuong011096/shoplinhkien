using WebLinhkien.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

using System.Configuration;

using System.Web.UI.WebControls;
using System.Data.Entity;

using System.Net.Mail;
using System.Net;
using WebLinhkien.ViewModels;

namespace WebLinhkien.Controllers
{

    public class LoginController : Controller
    {
        
        // GET: Login
        public ActionResult Login()
        {
            if (Session["UserName"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountViewModels.LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (ShopDatabaseContext db = new ShopDatabaseContext())
                {

                    var obj = db.Accounts.FirstOrDefault(a => a.Usernames.Equals(model.Username));
                    if (obj != null)
                    {
                        if (Crypto.VerifyHashedPassword(obj.Passwords, model.Password))
                        {
                            Session["Name"] = obj.NameUser.ToString() ;
                            Session["UserName"] = obj.Usernames.ToString();
                            Session["ID"] = obj;
                            var id = Session.SessionID;
                            
                             Session.Add("Username",obj);
                            return RedirectToAction("Index", "Home");

                        }
                        else
                            ViewBag.error = "Tài khoản hoặc mật khẩu không đúng";

                    }
                    else
                        ViewBag.error = "Tài khoản hoặc mật khẩu không đúng";


                }
            }
            return View();
        }
      

    
        ShopDatabaseContext db = new ShopDatabaseContext();
     
        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
      
        public ActionResult Register(ResignViewModel register)
        {
            try
            {
                if (ModelState.IsValid)
            {
                    var IsExitUser = checkuser(register.Usernames);
                    var IsExitEmail = checkuser(register.email);
                    if (IsExitUser)
                    {
                        ModelState.AddModelError("ExistUser", "Tên đăng nhập đã tồn tại");
                        return View(register);
                    }
                    else if (IsExitEmail)
                    {
                        ModelState.AddModelError("ExistEmail", "Email đã tồn tại");
                        return View(register);
                    }
                    else
                {
                    using (ShopDatabaseContext db = new ShopDatabaseContext())
                    {
                        var user = new Accounts();
                        user.Usernames = register.Usernames;
                        user.Passwords = Crypto.HashPassword(register.Passwords);
                        user.Tel = register.Tel;
                        user.IDRole = 2;
                        user.Addresss = register.Addresss;
                        user.createsdate = DateTime.Now;
                        user.email = register.email;
                        user.Gender = register.Gender;
                        user.NameUser = register.NameUser;
                        var result = db.Accounts.Add(user);
                        db.SaveChanges();
     
                        //var result = db.Entry(register).State = EntityState.Added;
                        //db.SaveChanges();
                        if (result != null)
                        {
                            ViewBag.Success = "Đăng kí thành công!";
                        register = new ResignViewModel();
                           
                        }
                        else
                        {
                            ModelState.AddModelError("", "Đăng kí không thành công");
                        }
                      

                    }
                }
                }
            }
            catch(Exception ex)
            {
              
            }
            //return RedirectToAction("Login", "Login");
            return View(register);
        }
      
        public bool checkuser (string Username)
        {
            return db.Accounts.Count(x=>x.Usernames == Username)>0;
        }
        public bool checkemail(string Emailuser)
        {
            return db.Accounts.Count(x => x.email == Emailuser) > 0;
        }
        
        [NonAction]
        public void SendvertificationLinkEmail(string EmailID,string activationCode,string emailFor="VerifyAccount")
        {
            var verifyUrl = "/Login/" + emailFor +"/" + activationCode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery,verifyUrl);
            var fromEmail = new MailAddress("cuongnguyen011096@gmail.com", "Shop Linh Kiện Điện Tử");
            var toEmail = new MailAddress(EmailID);
            var fromEmailPassword = "cuongnguyen";
            string subject = "";
            string body = "";
            if (emailFor == "VerifyAccount")
            {
                 subject = "Yêu cầu đổi mật khẩu tại đây";

                 body = "<br/><br/> Xác nhận đổi tài khoản tại đây -> " + "<a href ='" + link + "'>" + link + "</a>";
            }
            else if (emailFor == "ResetPassword")
            {
                subject = "Đổi mật khẩu tại đây";

                body = "<br/><br/> Chúng tôi nhận được yêu cầu đổi mật khẩu. Vui lòng nhấn vào đường dẫn để thực hiện việc đổi mật khẩu" 
                    + "<a href ='" + link + "'>" + " Đổi mật khẩu" + "</a>";
            }
            var smpt = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address,fromEmailPassword)
            };
            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            }) 
            smpt.Send(message);
        }
        public ActionResult Forgot()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Forgot(string EmailID)
        {
            string message = "";
            var account = db.Accounts.Where(a => a.email == EmailID).FirstOrDefault();

            if (account != null)
            {
                string resetcode = Guid.NewGuid().ToString();
                SendvertificationLinkEmail(account.email, resetcode, "ResetPassword");
                account.ResetPasswordCode = resetcode;
                db.Configuration.ValidateOnSaveEnabled = false;
                db.SaveChanges();
                message = "Email của bạn đã được gửi";
            }
            else
            {
                message = "Email không tồn tại";
            }
            ViewBag.Message = message;
            return View();
        }
        public ActionResult ResetPassword(string id)
        {
            var user = db.Accounts.Where(a => a.ResetPasswordCode == id).FirstOrDefault();
            if(user != null)
            {
                ResetPassword model = new ResetPassword();
                model.ResetCode = id;
                return View(model);
            }
            else
            {
                return HttpNotFound();
            }
          
        }
        [HttpPost]
        public ActionResult ResetPassword(ResetPassword model)
        {
            var message = "";
          
            if (!ModelState.IsValid)
            {
                var user = db.Accounts.Where(a => a.ResetPasswordCode == model.ResetCode).FirstOrDefault();
                if(user != null)
                {
                    user.Passwords = Crypto.HashPassword(model.NewPassword);
                    user.ResetPasswordCode = "";
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.SaveChanges();
                    message = "Đổi mật khẩu thành công";
                }
            }
            else
            {
                message = "Lỗi!";
            }
            ViewBag.Message = message;
            return View(model);
        }
 
     
        [HttpGet]
        public ActionResult ChangePassword()
        {
            if (Session["Username"] == null)
            {
                return View("Login");
            }
            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(string username, ViewModels.ChangePassword changePassword)
        {
            if (Session["Username"] == null)
            {
                return View("Login");
            }
            else
            {
                Session["Username"] = username;
            }

            Accounts obj = db.Accounts.Where(x => x.Usernames == username).FirstOrDefault<Accounts>();
            //var obj = db.Accounts.FirstOrDefault(a => a.Usernames.Equals(changePassword.Username));

            if (obj != null)
            {

                if (Crypto.VerifyHashedPassword(obj.Passwords, changePassword.OldPassword))
                {

                    obj.Passwords = Crypto.HashPassword(changePassword.NewPassword);
                    db.SaveChanges();
                    ViewBag.ThongBao = "Đổi mật khẩu thành công!";
                    return RedirectToAction("Index", "Home");
                }
            }
            ViewBag.ThongBao = "Thông tin nhập chưa đúng!";
            return RedirectToAction("Index", "Home");


        }
    }
}
