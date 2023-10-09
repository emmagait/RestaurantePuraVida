using Microsoft.AspNetCore.Mvc;

namespace RestauranteP.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
