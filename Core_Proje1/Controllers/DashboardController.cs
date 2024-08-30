using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.V2 = "İstatislikler";
            ViewBag.V3 = "İstatislik Sayfası";
            return View();
        }
    }
}
