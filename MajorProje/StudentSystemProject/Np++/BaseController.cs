using Service;
using System.Web.Mvc;
//using WebUI.ServiceReference;

namespace WebUI.Controllers
{
    public class BaseController : Controller
    {
        //private WcfServiceClient _projectService;
        //public WcfServiceClient ProjectService
        //{
        //    get
        //    {
        //        if (_projectService is null)
        //        {
        //            _projectService = new WcfServiceClient();
        //        }
        //        return _projectService;
        //    }
        //}
        private UserService _userService;
        public UserService UserService
        {
            get
            {
                if (_userService is null)
                {
                    _userService = new UserService();
                }
                return _userService;
            }
        }
    }
}