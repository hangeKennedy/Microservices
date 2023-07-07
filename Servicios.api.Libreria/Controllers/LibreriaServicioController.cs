using Microsoft.AspNetCore.Mvc;

namespace Servicios.api.Libreria.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class LibreriaServicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
