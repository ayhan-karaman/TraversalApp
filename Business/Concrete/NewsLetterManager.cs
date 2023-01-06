using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        private readonly INewsLetterDal _newsLetterDal;
        public void Add(NewsLetter entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(NewsLetter entity)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<NewsLetter>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public NewsLetter GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(NewsLetter entity)
        {
            throw new System.NotImplementedException();
        }
    }

}