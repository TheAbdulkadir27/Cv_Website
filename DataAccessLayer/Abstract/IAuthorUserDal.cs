using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IAuthorUserDal : IGenericDal<User>
    {
        List<User> GetByFilter(Expression<Func<User, bool>> filter);
    }
}
