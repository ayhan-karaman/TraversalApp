using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Add(SubAbout entity)
        {
            _subAboutDal.Insert(entity);
        }

        public void Delete(SubAbout entity)
        {
            _subAboutDal.Delete(entity);
        }

        public IDataResult<List<SubAbout>> GetAll()
        {
           return new SuccessDataResult<List<SubAbout>>(_subAboutDal.GetAll());
        }

        public SubAbout GetById(int id)
        {
            return _subAboutDal.Get(x => x.ID == id);
        }

        public void Update(SubAbout entity)
        {
            _subAboutDal.Update(entity);
        }
    }

}