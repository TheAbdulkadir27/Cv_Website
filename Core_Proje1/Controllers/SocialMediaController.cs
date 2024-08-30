using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager SocialMediaManager = new SocialMediaManager(new EfSocialMediaDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
            return View(SocialMediaManager.TGetList());
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.status = true;
            SocialMediaManager.TInsert(socialMedia);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = SocialMediaManager.GetByID(id);
            SocialMediaManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DetailSocialMedia(int id)
        {
            var value = SocialMediaManager.GetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult DetailSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.status = true;
            SocialMediaManager.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }
    }
}
