using DTO;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : BaseController
    {
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
        public ActionResult NewUserEdit(NewUserInfoDto model1)
        {
            var result = NewUserInfoService.Update(model1);
            if (result.Key)
                return RedirectToAction("NewUserIndex");
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
            return RedirectToAction("NewUserIndex");
        }
    }
}