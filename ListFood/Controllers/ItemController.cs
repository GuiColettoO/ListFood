using ListFood.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListFood.Controllers
{
    public class ItemController : Controller
    {
        private static IList<Item> _list = new List<Item>();
        private static int _id = 0; 

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Item item) 
        {
            item.Id = ++_id;
            _list.Add(item);
            TempData["message"] = "Item Cadastrado";
            return RedirectToAction("Register");
        }
    }
}
