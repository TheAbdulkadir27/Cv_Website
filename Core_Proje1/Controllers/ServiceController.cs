using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
            ViewBag.V1 = "Hizmetler Listesi";
            ViewBag.V2 = "Hizmetlerim";
            ViewBag.V3 = "Hizmetlerim Listesi";
            return View(serviceManager.TGetList());
        }
        public IActionResult DeleteService(int id)
        {
            serviceManager.TDelete(serviceManager.GetByID(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            ViewBag.V1 = "Hizmetler Listesi";
            ViewBag.V2 = "Hizmetlerim";
            ViewBag.V3 = "Hizmet Güncelleme Listesi";
            return View(serviceManager.GetByID(id));
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.V1 = "Hizmetler Listesi";
            ViewBag.V2 = "Hizmetlerim";
            ViewBag.V3 = "Hizmet Ekleme Listesi";
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TInsert(service);
            return RedirectToAction("Index");
        }
    }
}
