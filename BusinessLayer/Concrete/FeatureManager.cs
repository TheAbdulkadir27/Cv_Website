using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public Feature GetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetAll();
        }

        public void TInsert(Feature entity)
        {
            _featureDal.Insert(entity);
        }
        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
