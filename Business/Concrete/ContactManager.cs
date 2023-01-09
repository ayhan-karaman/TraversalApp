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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public IResult Add(Contact entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }

}