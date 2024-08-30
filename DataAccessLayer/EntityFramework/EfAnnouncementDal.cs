using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace DataAccessLayer.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public EfAnnouncementDal(DataBaseContext databasecontext) : base(databasecontext)
        {
        }

        public List<Announcement> GetByFilter(Expression<Func<Announcement, bool>> filter)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Announcements.Where(filter).ToList();
            }
        }
    }
}
