using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreIdentityDemo.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult NonSecureMethod()
        {
            return View();
        }

        [Authorize]
        public IActionResult SecureMethod()
        {
            return View();
        }
    }
}