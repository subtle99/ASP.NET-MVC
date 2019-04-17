using MyDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDiary.Controllers
{
    public class HomeController : Controller
    {
        DiaryDB db = new DiaryDB();
        public ActionResult Index()
        {
            var diaries = new List<Diary>();
            if(Session["User"]!=null)
            {
                var userId = ((UserInfo)Session["User"]).Id;
                diaries = db.Diaries.Where(d => d.UserId == userId).ToList();
            }
            return View(diaries);
        }
        public ActionResult Remove(int Id)
        {
            var diary= db.Diaries.FirstOrDefault(d => d.Id == Id);
            db.Diaries.Remove(diary);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Diary diary)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            diary.PubDate = DateTime.Now;
            diary.UserId = ((UserInfo)Session["user"]).Id;
            db.Diaries.Add(diary);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}