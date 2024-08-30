using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IAuthorMessageService : IGenericService<AuthorMessage>
    {
        List<AuthorMessage> TGetListByFilter(Expression<Func<AuthorMessage, bool>> filter);
    }
}
