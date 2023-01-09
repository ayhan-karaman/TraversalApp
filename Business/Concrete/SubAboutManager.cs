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

        public IResult Add(SubAbout entity)
        {
            _subAboutDal.Insert(entity);
            return new SuccessResult("");
        }

        public IResult Delete(SubAbout entity)
        {
            _subAboutDal.Delete(entity);
             return new SuccessResult();
        }

        public IDataResult<List<SubAbout>> GetAll()
        {
           return new SuccessDataResult<List<SubAbout>>(_subAboutDal.GetAll());
        }

        public IDataResult<SubAbout> GetById(int id)
        {
            return new SuccessDataResult<SubAbout>(_subAboutDal.Get(x => x.ID == id));
        }

        public IResult Update(SubAbout entity)
        {
            _subAboutDal.Update(entity);
             return new SuccessResult();
        }
    }

}