using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class Feature2Manager : IFeature2Service
    {
        private readonly IFeature2Dal _feature2Dal;
        public IResult Add(Feature2 entity)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Feature2 entity)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Feature2>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Feature2> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Feature2 entity)
        {
            throw new System.NotImplementedException();
        }
    }

}