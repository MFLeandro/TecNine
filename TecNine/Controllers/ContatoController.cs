using Microsoft.AspNetCore.Mvc;

namespace TecNine.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}