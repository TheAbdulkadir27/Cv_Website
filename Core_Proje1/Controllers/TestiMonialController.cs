using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Controllers
{
    public class TestiMonialController : Controller
    {
        TestiMonialsManager TestiMonialsManager = new TestiMonialsManager(new EfTestiMonialsDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
            return View(TestiMonialsManager.TGetList());
        }
        public IActionResult DeleteTestiMonial(int id)
        {
            TestiMonialsManager.TDelete(TestiMonialsManager.GetByID(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTestiMonial(int id)
        {
            return View(TestiMonialsManager.GetByID(id));
        }
        [HttpPost]
        public IActionResult EditTestiMonial(TestiMonials testiMonials)
        {
            TestiMonialsManager.TUpdate(testiMonials);
            return RedirectToAction("Index");
        }

    }
}
