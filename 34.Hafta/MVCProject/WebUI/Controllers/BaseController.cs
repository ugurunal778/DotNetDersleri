
using System.Web.Mvc;
using WebUI.MvcProjectService;

namespace WebUI.Controllers
{
    public class BaseController : Controller
    {
        private MvcSampleWcfClient _projectService;
        public MvcSampleWcfClient ProjectService
        {
            get
            {
                if (_projectService is null)
                {
                    _projectService = new MvcSampleWcfClient();
                }
                return _projectService;
            }
        }


    }
}