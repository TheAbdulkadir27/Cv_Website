using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Controllers
{
    public class AboutController : Controller
    {
        AboutManager AboutManager = new AboutManager(new EfAboutDal(new DataAccessLayer.Context.DataBaseContext()));

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.V1 = "hakkımda Listesi";
            ViewBag.V2 = "hakkımda Çıkanlar";
            ViewBag.V3 = "hakkımda Sayfası";
            return View(AboutManager.GetByID(1));
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            AboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
