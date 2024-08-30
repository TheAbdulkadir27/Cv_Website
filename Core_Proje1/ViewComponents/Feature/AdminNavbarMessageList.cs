using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.ViewComponents.Feature
{
    public class AdminNavbarMessageList : ViewComponent
    {
        AuthorMessageManager AuthorMessageManager = new AuthorMessageManager(new EfAuthorMessageDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke() => View(AuthorMessageManager.TGetListByFilter(x => x.Sender == "admin@gmail.com").OrderByDescending(x => x.ID).Take(3).ToList());
    }
}
