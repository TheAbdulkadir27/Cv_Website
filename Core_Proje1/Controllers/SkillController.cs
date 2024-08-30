using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Controllers
{
    public class SkillController : Controller
    {
        SkillManager SkillManager = new SkillManager(new EfSkillDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
            ViewBag.V1 = "Yetenek Listesi";
            ViewBag.V2 = "Yetenekler";
            ViewBag.V3 = "Yetenek Listesi";
            return View(SkillManager.TGetList());
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.V1 = "Yetenek Ekleme";
            ViewBag.V2 = "Yetenekler";
            ViewBag.V3 = "Yetenek Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            SkillManager.TInsert(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            SkillManager.TDelete(SkillManager.GetByID(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = SkillManager.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            SkillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
