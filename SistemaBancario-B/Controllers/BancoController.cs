using Microsoft.AspNetCore.Mvc;

namespace SistemaBancario_B.Controllers
{
    public class BancoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
