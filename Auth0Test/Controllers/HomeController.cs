using System.Security.Claims;
using System.Web.Mvc;

namespace WebApplication15.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            return View();
        }

        [Authorize(Roles = "admin")]
        public ActionResult About()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}