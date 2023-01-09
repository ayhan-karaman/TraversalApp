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
    public class OtherDetailsManager : IOtherDetailsService
    {
        private readonly IOtherDetailsDal _otherDetailsDal;

        public OtherDetailsManager(IOtherDetailsDal otherDetailsDal)
        {
            _otherDetailsDal = otherDetailsDal;
        }

        public IResult Add(OtherDetails entity)
        {
            _otherDetailsDal.Insert(entity);
            return new SuccessResult("");
        }

        public IResult Delete(OtherDetails entity)
        {
            _otherDetailsDal.Delete(entity);
             return new SuccessResult();
        }

        public IDataResult<List<OtherDetails>> GetAll()
        {
            return new SuccessDataResult<List<OtherDetails>>(_otherDetailsDal.GetAll());
        }

        public IDataResult<OtherDetails> GetById(int id)
        {
            return new SuccessDataResult<OtherDetails>(_otherDetailsDal.Get(x => x.ID == id));
        }

        public IResult Update(OtherDetails entity)
        {
            _otherDetailsDal.Update(entity);
             return new SuccessResult();
        }
    }
}