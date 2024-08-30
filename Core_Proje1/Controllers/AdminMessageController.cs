using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje1.Controllers
{
    public class AdminMessageController : Controller
    {
        AuthorMessageManager AuthorMessageManager = new AuthorMessageManager(new EfAuthorMessageDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult ReceiverMessageList()
        {
            string p = "abdulkadiryonucuoglu2727@gmail.com";
            var values = AuthorMessageManager.TGetListByFilter(x => x.Receiver == p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p = "abdulkadiryonucuoglu2727@gmail.com";
            var values = AuthorMessageManager.TGetListByFilter(x => x.Sender == p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            return View(AuthorMessageManager.GetByID(id));
        }

        public IActionResult DeleteMessage(int id)
        {
            AuthorMessageManager.TDelete(AuthorMessageManager.GetByID(id));
            return View();
        }

        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(AuthorMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DataBaseContext dataBaseContext = new DataBaseContext();
            var username = dataBaseContext.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = username!;
            AuthorMessageManager.TInsert(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
