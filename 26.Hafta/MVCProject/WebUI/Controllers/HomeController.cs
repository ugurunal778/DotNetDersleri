using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserInfoDto userInfoDto)
        {
            UserInfoService.Insert(userInfoDto);
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            var result = UserInfoService.GetAll();
            return View(result);
        }
        public ActionResult Edit(int id)
        {
            var result = UserInfoService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(UserInfoDto model)
        {
            UserInfoService.Update(model);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var result = UserInfoService.GetById(id);
            return View(result);
        }
        public ActionResult Delete(int id)
        {
            UserInfoService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}