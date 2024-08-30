using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje1.Controllers
{
    [AllowAnonymous]
    public class AuthorUserController : Controller
    {
        AuthorUserManager authorUserManager = new AuthorUserManager(new EfAuthorUserDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(authorUserManager.TGetList());
            return Json(values);
        }
    }
}
