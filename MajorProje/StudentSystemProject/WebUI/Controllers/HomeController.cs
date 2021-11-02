using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.ServiceReference;

namespace WebUI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserDto userDto)
        {
            ProjectService.InsertUser(userDto);
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            var result = ProjectService.GetAllUser();
            return View(result);
        }
        public ActionResult Edit(int id)
        {
            var result = ProjectService.GetByIdUser(id);
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(UserDto model)
        {
            ProjectService.UpdateUser(model);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var result = ProjectService.GetByIdUser(id);
            return View(result);
        }
        public ActionResult Delete(int id)
        {
            ProjectService.RemoveUser(id);
            return RedirectToAction("Index");
        }
    }
}