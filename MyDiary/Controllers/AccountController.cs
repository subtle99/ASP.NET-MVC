using MyDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDiary.Controllers
{
    public class AccountController : Controller
    {
        DiaryDB db = new DiaryDB();
        public ActionResult Logoff()
        {
            Session.Clear();
            return RedirectToAction("Login", "Account");//login方法  Account控制器中
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserInfo user)
        {
            var item = db.Users.FirstOrDefault(u => u.UserName == user.UserName && u.PassWord == user.PassWord);
            if(item!=null)
            {
                Session["User"] = item;
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Login Error");
            return View(user);
        }
        [HttpPost]
        public ActionResult Register(UserInfo user)
        {
            if(db.Users.FirstOrDefault(u=>u.UserName==user.UserName)!=null)
            {
                ModelState.AddModelError("", "用户名已存在");
                return View(user);
            }
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Login","Account");
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}