using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Add(DestinationImage entity)
        {
            _destinationImageDal.Insert(entity);
        }

        public void Delete(DestinationImage entity)
        {
            _destinationImageDal.Delete(entity);
        }

        public List<DestinationImage> GetAll()
        {
            return _destinationImageDal.GetAll();
        }

        public DestinationImage GetById(int id)
        {
            return _destinationImageDal.Get(x => x.ID == id);
        }

        public void Update(DestinationImage entity)
        {
            _destinationImageDal.Update(entity);
        }
    }
}