using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public IResult Add(Guide entity)
        {
            _guideDal.Insert(entity);
            return new SuccessResult("");
        }

        public IResult Delete(Guide entity)
        {
            _guideDal.Delete(entity);
             return new SuccessResult();
        }

        public IDataResult<List<Guide>> GetAll()
        {
            return new SuccessDataResult<List<Guide>>(_guideDal.GetAll());
        }

        public IDataResult<Guide> GetById(int id)
        {
            return new SuccessDataResult<Guide>(_guideDal.Get(x => x.ID == id));
        }

        public IResult Update(Guide entity)
        {
            _guideDal.Update(entity);
             return new SuccessResult();
        }
    }

}