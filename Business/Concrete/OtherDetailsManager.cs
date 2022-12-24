using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
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

        public void Add(OtherDetails entity)
        {
            _otherDetailsDal.Insert(entity);
        }

        public void Delete(OtherDetails entity)
        {
            _otherDetailsDal.Delete(entity);
        }

        public List<OtherDetails> GetAll()
        {
            return _otherDetailsDal.GetAll();
        }

        public OtherDetails GetById(int id)
        {
            return _otherDetailsDal.Get(x => x.ID == id);
        }

        public void Update(OtherDetails entity)
        {
            _otherDetailsDal.Update(entity);
        }
    }
}