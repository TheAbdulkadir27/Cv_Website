using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        private readonly IToDoListDal _todolistdal;
        public ToDoListManager(IToDoListDal todolistdal)
        {
            _todolistdal = todolistdal;
        }

        public ToDoList GetByID(int id)
        {
            return _todolistdal.GetByID(id);
        }
        public void TDelete(ToDoList entity)
        {
            _todolistdal.Delete(entity);
        }
        public List<ToDoList> TGetList()
        {
            return _todolistdal.GetAll().Where(x => x.Status == true).ToList();
        }

        public void TInsert(ToDoList entity)
        {
            _todolistdal.Insert(entity);
        }

        public void TUpdate(ToDoList entity)
        {
            _todolistdal.Update(entity);
        }
    }
}
