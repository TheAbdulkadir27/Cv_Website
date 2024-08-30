using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IAnnouncementDal : IGenericDal<Announcement>
    {
        List<Announcement> GetByFilter(Expression<Func<Announcement, bool>> filter);
    }
}
