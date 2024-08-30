using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.Controllers
{
    public class ProjeController : Controller
    {
        PortFolioManager PortFolioManager = new PortFolioManager(new EfPortFolioDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
            ViewBag.V1 = "Proje Listesi";
            ViewBag.V2 = "Projeler";
            ViewBag.V3 = "Proje Listesi";
            return View(PortFolioManager.TGetList());
        }
        [HttpGet]
        public IActionResult AddProje()
        {
            ViewBag.V1 = "Proje Listesi";
            ViewBag.V2 = "Projeler";
            ViewBag.V3 = "Proje Listesi";
            return View();
        }

        [HttpPost]
        public IActionResult AddProje(PortFolio portFolio)
        {
            PortFolioValidator validationRules = new PortFolioValidator();
            ValidationResult result = validationRules.Validate(portFolio);
            if (result.IsValid)
            {
                PortFolioManager.TInsert(portFolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorCode);
                }
            }
            return View();
        }
        public IActionResult DeleteProje(int id)
        {
            PortFolioManager.TDelete(PortFolioManager.GetByID(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProje(int id)
        {
            ViewBag.V1 = "Proje Listesi";
            ViewBag.V2 = "Projeler";
            ViewBag.V3 = "Proje Listesi";
            return View(PortFolioManager.GetByID(id));
        }
        [HttpPost]
        public IActionResult UpdateProje(PortFolio portFolio)
        {
            PortFolioValidator validationRules = new PortFolioValidator();
            ValidationResult result = validationRules.Validate(portFolio);
            if (result.IsValid)
            {
                PortFolioManager.TUpdate(portFolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorCode);
                }
            }
            return View();
        }
    }
}
