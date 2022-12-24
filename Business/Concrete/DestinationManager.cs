using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

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

        public List<Destination> GetAllDestinationIncludes()
        {
             return _destinationDal.GetAllDestinationIncludesDal();
        }

        public List<Destination> GetAll()
        {
             return _destinationDal.GetAll();
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