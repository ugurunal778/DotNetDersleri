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
            var redirectToAction = "";
            this.RunSafely(() =>
            {
                var serviceResult = UserInfoService.Insert(userInfoDto);
                redirectToAction = "Index";
            },
            ex =>
            {
                redirectToAction = "Error";
            });

            return RedirectToAction(redirectToAction);
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
            var result = UserInfoService.Update(model);

            if (result.Key)
                return RedirectToAction("Index");
            else
            {
                ViewBag.ErrorText = result.Value;
                return View();
            }

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