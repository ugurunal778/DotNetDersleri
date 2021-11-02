using Service;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        private NewUserInfoService _newUserInfoService;
        public NewUserInfoService NewUserInfoService
        {
            get
            {
                if(_newUserInfoService is null)
                    _newUserInfoService = new NewUserInfoService();
                return _newUserInfoService;
            }
        }
    }
}