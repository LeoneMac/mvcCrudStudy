using Microsoft.AspNetCore.Mvc;

namespace mvcCrudStudy.Controllers
{
    public class Produtos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
