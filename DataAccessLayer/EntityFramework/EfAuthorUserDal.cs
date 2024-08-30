using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace DataAccessLayer.EntityFramework
{
    public class EfAuthorUserDal : GenericRepository<User>, IAuthorUserDal
    {
        public EfAuthorUserDal(DataBaseContext databasecontext) : base(databasecontext)
        {

        }

        public List<User> GetByFilter(Expression<Func<User, bool>> filter)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Users.Where(filter).ToList();
            }
        }
    }
}
