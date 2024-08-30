using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje1.Controllers
{
    public class Experince2Controller : Controller
    {
        ExperianceManager ExperianceManager = new ExperianceManager(new EfExperianceDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListExperiance()
        {
            var values = JsonConvert.SerializeObject(ExperianceManager.TGetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperiance(Experiance experiance)
        {
            ExperianceManager.TInsert(experiance);
            return View();
        }

        public IActionResult GetById(int id)
        {
            var v = ExperianceManager.GetByID(id);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        public IActionResult DeleteExperiance(int id)
        {
            var v = ExperianceManager.GetByID(id);
            ExperianceManager.TDelete(v);
            return NoContent();
        }
    }
}
