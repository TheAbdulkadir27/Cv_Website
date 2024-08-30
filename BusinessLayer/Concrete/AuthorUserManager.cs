using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;
namespace BusinessLayer.Concrete
{
    public class AuthorUserManager : IAuthorUserService
    {
        private readonly IAuthorUserDal _authorUserdal;
        public AuthorUserManager(IAuthorUserDal authorUserdal)
        {
            _authorUserdal = authorUserdal;
        }

        public User GetByID(int id)
        {
           return _authorUserdal.GetByID(id);
        }

        public void TDelete(User entity)
        {
            _authorUserdal.Delete(entity);
        }

        public List<User> TGetList()
        {
            return _authorUserdal.GetAll();
        }

        public List<User> TGetListByFilter(Expression<Func<User, bool>> filter)
        {
            return _authorUserdal.GetByFilter(filter);
        }

        public void TInsert(User entity)
        {
            _authorUserdal.Insert(entity);
        }

        public void TUpdate(User entity)
        {
            _authorUserdal.Update(entity);
        }
    }
}
