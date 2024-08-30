using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.SocialMedia
{
    public class SocialMediaList : ViewComponent
    {
        SocialMediaManager SocialMediaManager = new SocialMediaManager(new EfSocialMediaDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke()
        {
             return View(SocialMediaManager.TGetList());
        }
    }
}
