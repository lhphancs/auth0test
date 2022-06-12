// Controllers/AccountController.cs

using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using System.Web;
using System.Web.Mvc;

public class AccountController : Controller
{
    public ActionResult Login(string returnUrl)
    {
        HttpContext.GetOwinContext().Authentication.Challenge(new AuthenticationProperties
        {
            RedirectUri = returnUrl ?? Url.Action("Index", "Home")
        },
            "Auth0");
        return new HttpUnauthorizedResult();
    }

    [Authorize]
    public void Logout()
    {
        HttpContext.GetOwinContext().Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
        HttpContext.GetOwinContext().Authentication.SignOut("Auth0");
    }
}