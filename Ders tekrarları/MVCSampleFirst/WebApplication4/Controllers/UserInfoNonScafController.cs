using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class UserInfoNonScafController : Controller
    {

        private MVDFirstAppEntities db = new MVDFirstAppEntities();
        // GET: UserInfoNonScaf
        public ActionResult Index()
        {
            return View(db.UserInfo.ToList());
        }
        public ActionResult Details(int id)
        {
            return View(db.UserInfo.FirstOrDefault(x => x.Id == id));
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(db.UserInfo.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteComfirmed(int id)
        {
            db.UserInfo.Remove(db.UserInfo.FirstOrDefault(x => x.Id == id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View(db.UserInfo.FirstOrDefault(x=> x.Id==id));
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,UserName,Password,CreatedDate")] UserInfo userInfo)
        {
            db.Entry(userInfo).State = EntityState.Modified;
            userInfo.ModifiedDate = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include ="FirstName,LastName,UserName,Password")]UserInfo userInfo)
        {
            userInfo.CreatedDate = DateTime.Now;
            userInfo.ModifiedDate = DateTime.Now;
            db.UserInfo.Add(userInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}