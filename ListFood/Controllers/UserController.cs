using Microsoft.AspNetCore.Mvc;

namespace ListFood.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
