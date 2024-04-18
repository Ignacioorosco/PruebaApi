using Microsoft.AspNetCore.Mvc;

namespace PruebaApi.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
