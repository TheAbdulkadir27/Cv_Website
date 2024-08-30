using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.Areas.Author.Controllers
{
    [Area("Author")]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
