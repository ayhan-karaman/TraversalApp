using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class About2Manager : IAbout2Service
    {
        private readonly IAbout2Dal _about2Dal;
        public void Add(About2 entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(About2 entity)
        {
            throw new NotImplementedException();
        }

        public List<About2> GetAll()
        {
            throw new NotImplementedException();
        }

        public About2 GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(About2 entity)
        {
            throw new NotImplementedException();
        }
    }
}