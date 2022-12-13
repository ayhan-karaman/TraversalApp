using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Business.Abstract;
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

        public void Add(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void Delete(About entity)
        {
           _aboutDal.Delete(entity);
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(x => x.ID == id);
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}