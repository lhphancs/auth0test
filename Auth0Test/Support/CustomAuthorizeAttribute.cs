using System.Net;
using System.Web.Mvc;

namespace MvcApplication.Support
{
    /* We use [CustomAuthorizeAttribute] instead of [Authorize] because [Authorize] has an issue where the user is authenticated, but does not have authorization. 
     * It creates an infinite loop. See https://www.blinkingcaret.com/2016/01/20/authorization-redirect-loops-asp-net-mvc/
    */
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result = new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}

