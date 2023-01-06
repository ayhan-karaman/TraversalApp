using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using Microsoft.AspNetCore.Http;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
          
        }

        public void Add(Destination entity)
        {
             _destinationDal.Insert(entity);

        }

        public void Delete(Destination entity)
        {
            _destinationDal.Delete(entity);
        }

        public IDataResult<List<Destination>> GetAllDestinationIncludes()
        {
             return new SuccessDataResult<List<Destination>>(_destinationDal.GetAllDestinationIncludesDal());
        }

        public IDataResult<List<Destination>> GetAll()
        {
             return new SuccessDataResult<List<Destination>>(_destinationDal.GetAllDestinationIncludesDal());
        }

        public Destination GetById(int id)
        {
            return _destinationDal.Get(x => x.ID == id);
        }

        public void Update(Destination entity)
        {
            _destinationDal.Update(entity);
        }

        public Destination GetByIdDestinationIncludes(int id)
        {
            return _destinationDal.GetDestinationIncludesDal(x => x.ID == id);
        }

    

       
    }

}