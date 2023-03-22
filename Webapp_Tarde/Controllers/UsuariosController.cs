using Microsoft.AspNetCore.Mvc;

namespace Webapp_Tarde.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
