using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IAuthorMessageDal : IGenericDal<AuthorMessage>
    {
        List<AuthorMessage> GetByFilter(Expression<Func<AuthorMessage, bool>> filter);
    }
}
