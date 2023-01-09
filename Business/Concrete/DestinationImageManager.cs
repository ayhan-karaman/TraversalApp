using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.UploadFile;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class DestinationImageManager : IDestinationImageService
    {
        private readonly IDestinationImageDal _destinationImageDal;

        public DestinationImageManager(IDestinationImageDal destinationImageDal)
        {
            _destinationImageDal = destinationImageDal;
        }

        public IResult Add(DestinationImage entity)
        {

            _destinationImageDal.Insert(entity);
            return new SuccessResult("");
        }

        public IResult AddImage(ICollection<IFormFile> files, int id)
        {
            
            if(ParamerterFileCount(files, id))
            {
                    foreach (var file in files)
                    {
                        DestinationImage destinationImage = new DestinationImage();
                        destinationImage.DestinationID = id;
                        string path = UploadHelper.AddFile(file, @"images/");
                        destinationImage.PathName = path;
                        Add(destinationImage);
                       
                    }
                     return new SuccessResult("Resimler eklendi");
            }
            else
                return new ErrorResult("Üçten fazla resim ekleymezsiniz");
            
        }

        public IResult Delete(DestinationImage entity)
        {
            _destinationImageDal.Delete(entity);
             return new SuccessResult();
        }

        public IDataResult<List<DestinationImage>> GetAll()
        {
            return new SuccessDataResult<List<DestinationImage>>(_destinationImageDal.GetAll());
        }

        public IDataResult<List<DestinationImage>> GetByDestinationId(int destinationId)
        {
            return new SuccessDataResult<List<DestinationImage>>(_destinationImageDal.GetAll(x => x.DestinationID == destinationId));
        }

        public IDataResult<DestinationImage> GetById(int id)
        {
            return new SuccessDataResult<DestinationImage>  (_destinationImageDal.Get(x => x.ID == id));
        }

        public IResult Update(DestinationImage entity)
        {
            _destinationImageDal.Update(entity);
             return new SuccessResult();
        }


        private bool ParamerterFileCount<T>(ICollection<T> collection, int destinationId)
        {
            var imagesGetByDestinationId =  _destinationImageDal.GetAll(x => x.DestinationID == destinationId);
             if(collection.Count > 3 ||  imagesGetByDestinationId.Count >= 3)
             {
                return false;
             }
             return true;
        }
    }
}