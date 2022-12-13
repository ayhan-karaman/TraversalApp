using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature entity)
        {
            _featureDal.Insert(entity);
        }

        public void Delete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public List<Feature> GetAll()
        {
           return _featureDal.GetAll();
        }

        public Feature GetById(int id)
        {
            return _featureDal.Get(x => x.ID == id);
        }

        public void Update(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }

}