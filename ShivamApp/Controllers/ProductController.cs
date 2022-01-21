using Microsoft.AspNetCore.Mvc;

namespace ShivamApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
