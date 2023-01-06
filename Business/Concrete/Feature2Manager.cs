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
        public void Add(Feature2 entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Feature2 entity)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Feature2>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Feature2 GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Feature2 entity)
        {
            throw new System.NotImplementedException();
        }
    }

}