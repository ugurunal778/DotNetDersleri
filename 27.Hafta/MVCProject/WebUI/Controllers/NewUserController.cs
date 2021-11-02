using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class NewUserController : BaseController
    {
        // GET: NewUser
        public ActionResult NewUserCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewUserCreate(NewUserInfoDto newUserInfoDto)
        {
            var redirectToAction = "";
            this.RunSafely(() =>
            {
                var serviceResult = NewUserInfoService.Insert(newUserInfoDto);
                redirectToAction = "NewUserIndex";
            },
            ex =>
            {
                redirectToAction = "Error";
            });

            return RedirectToAction(redirectToAction);
        }
        public ActionResult NewUserIndex()
        {
            var result = NewUserInfoService.GetAll();
            return View(result);
        }
        public ActionResult NewUserEdit(int id)
        {
            var result = NewUserInfoService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult NewUserEdit(NewUserInfoDto model)
        {
            var result = NewUserInfoService.Update(model);

            if (result.Key)
                return RedirectToAction("Index");
            else
            {
                ViewBag.ErrorText = result.Value;
                return View();
            }
        }
        public ActionResult NewUserDetails(int id)
        {
            var result = NewUserInfoService.GetById(id);
            return View(result);
        }
        public ActionResult NewUserDelete(int id)
        {
            NewUserInfoService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}