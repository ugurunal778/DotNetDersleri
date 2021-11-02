using Service;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class BaseController : Controller
    {
        private UserInfoService _userInfoService;
        public UserInfoService UserInfoService
        {
            get
            {
                if (_userInfoService is null)
                {
                    _userInfoService = new UserInfoService();
                }
                return _userInfoService;
            }
        }

        private NewUserInfoService _newUserInfoService;
        public NewUserInfoService NewUserInfoService
        {
            get
            {
                if (_newUserInfoService is null)
                {
                    _newUserInfoService = new NewUserInfoService();
                }
                return _newUserInfoService;
            }
        }
    }
}