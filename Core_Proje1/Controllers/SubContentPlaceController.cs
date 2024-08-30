using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.Controllers
{
    public class SubContentPlaceController : Controller
    {
        ContactManager ContactManager = new ContactManager(new EfContactDal(new DataAccessLayer.Context.DataBaseContext()));
        [HttpGet]
        public IActionResult Index()
        {
            return View(ContactManager.GetByID(1));
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ContactManager.TUpdate(contact);
            return RedirectToAction("Index","Default");
        }
    }
}
