using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using durer2.ServiceReference;

namespace durer2.Controllers
{
    public class UserAuthorize : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            WcfServiceClient uf = new WcfServiceClient();
            var userCookie = httpContext.Request.Cookies["User"];
            var passCookie = httpContext.Request.Cookies["Pass"];
            if (userCookie != null && passCookie != null && uf.CheckLoginUser(userCookie.Value, System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(passCookie.Value))))
            {
                return true;
            }
            httpContext.Response.Redirect("/Admin/Login");
            return false;
        }
    }
}