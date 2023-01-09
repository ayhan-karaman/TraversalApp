using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Feature entity)
        {
            _featureDal.Insert(entity);
            return new SuccessResult("");
        }

        public IResult Delete(Feature entity)
        {
            _featureDal.Delete(entity);
             return new SuccessResult();
        }

        public IDataResult<List<Feature>> GetAll()
        {
           return new SuccessDataResult<List<Feature>>(_featureDal.GetAll());
        }

        public IDataResult<Feature> GetById(int id)
        {
            return new SuccessDataResult<Feature>(_featureDal.Get(x => x.ID == id));
        }

        public IResult Update(Feature entity)
        {
            _featureDal.Update(entity);
             return new SuccessResult();
        }
    }

}