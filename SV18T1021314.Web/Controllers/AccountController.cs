using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SV18T1021314.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Authorize]
    public class AccountController : Controller
    {
        /// <summary>
        /// Giao diện đăng nhập
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public ActionResult  Login()
        {
            return View();
        }
        /// <summary>
        /// Xử lý yêu cầu đăng nhập
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            //TODO: code lại để kiểm tra tài khoản từ tỏng CSDL
            if(username == "abc@cdh.com" && password == "1")
            {
                //ghi lại coooki phiên đăng nhập
                System.Web.Security.FormsAuthentication.SetAuthCookie(username, false);
                //quay vè trang chủ
                return RedirectToAction("Index", "Home");
            }
            ViewBag.UserName = username;
            ViewBag.Message = "Đăng nhập thất bại";
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}