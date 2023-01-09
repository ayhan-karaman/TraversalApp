using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
         private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public IResult Add(About entity)
        {
            _aboutDal.Insert(entity);
            return new SuccessResult("");
        }

        public IResult Delete(About entity)
        {
           _aboutDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<About> GetById(int id)
        {
            return new SuccessDataResult<About>(_aboutDal.Get(x => x.ID == id));
        }

        public IDataResult<List<About>> GetAll()
        {
            return new SuccessDataResult<List<About>> (_aboutDal.GetAll());
        }

        public IResult Update(About entity)
        {
            _aboutDal.Update(entity);
            return new SuccessResult();
        }
    }
}