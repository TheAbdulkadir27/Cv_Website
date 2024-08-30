using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messagedal;
        public MessageManager(IMessageDal messagedal)
        {
            _messagedal = messagedal;
        }
        public Message GetByID(int id)
        {
            return _messagedal.GetByID(id);
        }

        public void TDelete(Message entity)
        {
            _messagedal.Delete(entity);
        }

        public List<Message> TGetList()
        {
            return _messagedal.GetAll();
        }

        public void TInsert(Message entity)
        {
            _messagedal.Insert(entity);
        }

        public void TUpdate(Message entity)
        {
            _messagedal.Update(entity);
        }
    }
}
