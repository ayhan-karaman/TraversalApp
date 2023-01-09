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
        private readonly IDestinationImageService  _destinationImageService;
        public DestinationManager(IDestinationDal destinationDal, IDestinationImageService destinationImageService)
        {
            _destinationDal = destinationDal;
            _destinationImageService = destinationImageService;
        }

        public IResult Add(Destination entity)
        {
             _destinationDal.Insert(entity);
             return new SuccessResult("rota kaydınız oluşturuldu");

        }

        public IResult Delete(Destination entity)
        {
            _destinationDal.Delete(entity);
             return new SuccessResult();
        }

        public IDataResult<List<Destination>> GetAllDestinationIncludes()
        {
             var data  =  _destinationDal.GetAllDestinationIncludesDal();
            
             if(data.Count > 0 )
                return new SuccessDataResult<List<Destination>>(data, "Rotalar Listelendi");
             return new ErrorDataResult<List<Destination>>(null, "Rotalar bulunamadı....");
        }

        public IDataResult<List<Destination>> GetAll()
        {
             return new SuccessDataResult<List<Destination>>(_destinationDal.GetAllDestinationIncludesDal());
        }

        public IDataResult<Destination> GetById(int id)
        {
            var result = _destinationDal.Get(x => x.ID == id);
            if(result != null)
                return new SuccessDataResult<Destination>(result);
            return new ErrorDataResult<Destination>(null, "Bu Id numarası ile herhangi bir Rota bulunamadı!");
        }

        public IResult Update(Destination entity)
        {
            _destinationDal.Update(entity);
             return new SuccessResult();
        }

        public Destination GetByIdDestinationIncludes(int id)
        {
            return _destinationDal.GetDestinationIncludesDal(x => x.ID == id);
        }

        public IResult AddDestinationAndImage(ICollection<IFormFile> files, Destination destination)
        {
                var result =  ParamerterFileCount(files);
                if(!result.Success)
                    return new ErrorResult(result.Message);
                
                var added = Add(destination);
                if(added.Success)
                {
                    var destinationImage =  _destinationImageService.AddImage(files, destination.ID);
                    return destinationImage.Success ? 
                    new SuccessResult(added.Message) : new ErrorResult();

                }
                return new ErrorResult(added.Message);
            
           
        }

         private IResult ParamerterFileCount<T>(ICollection<T> collection)
        {
            
             if(collection.Count > 3)
             {
                return new ErrorResult("Lütfen maksimum 3 adet resim seçiniz!");
             }
             return new SuccessResult();
        }
    }

}