using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class About2Manager : IAbout2Service
    {
        private readonly IAbout2Dal _about2Dal;
        public IResult Add(About2 entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(About2 entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<About2>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<About2> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(About2 entity)
        {
            throw new NotImplementedException();
        }
    }
}