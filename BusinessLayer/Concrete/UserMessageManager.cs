using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
namespace BusinessLayer.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        private readonly IUserMessageDal _userMessage;
        public UserMessageManager(IUserMessageDal userMessage)
        {
            _userMessage = userMessage;
        }
        public UserMessage GetByID(int id)
        {
            return _userMessage.GetByID(id);
        }

        public List<UserMessage> GetUserMessagesWithUserService() => _userMessage.GetAllUserMessageWithUser();

        public void TDelete(UserMessage entity)
        {
            _userMessage.Delete(entity);
        }

        public List<UserMessage> TGetList()
        {
            return _userMessage.GetAll();
        }

        public void TInsert(UserMessage entity)
        {
            _userMessage.Insert(entity);
        }

        public void TUpdate(UserMessage entity)
        {
            _userMessage.Update(entity);
        }
    }
}
