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
            return View(_list);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _list.First(i => i.Id == id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Item item)
        {
            var index = _list.ToList().FindIndex(i => i.Id == item.Id);
            _list[index] = item;

            TempData["message"] = "Item Update!";

            return RedirectToAction("Index");
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

        [HttpPost]
        public IActionResult Remove(int id)
        {
            //Remove o veiculo da lista (pesquisando o veiculo pelo id)
            _list.Remove(_list.First(i => i.Id == id));
            //Mensagem de sucesso
            TempData["msg"] = "Item remove!";
            //Redirect para a Index
            return RedirectToAction("Index");
        }
    }
}
