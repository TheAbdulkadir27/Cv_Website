using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccessLayer.EntityFramework
{
    public class EfAuthorMessageDal : GenericRepository<AuthorMessage>, IAuthorMessageDal
    {
        public EfAuthorMessageDal(DataBaseContext databasecontext) : base(databasecontext)
        {

        }

        public List<AuthorMessage> GetByFilter(Expression<Func<AuthorMessage, bool>> filter)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                return context.AuthorMessages.Where(filter).ToList();
            }
        }
    }
}
