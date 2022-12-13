using System.Collections.Generic;
using Business.Abstract;
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

        public void Add(Guide entity)
        {
            _guideDal.Insert(entity);
        }

        public void Delete(Guide entity)
        {
            _guideDal.Delete(entity);
        }

        public List<Guide> GetAll()
        {
            return _guideDal.GetAll();
        }

        public Guide GetById(int id)
        {
            return _guideDal.Get(x => x.ID == id);
        }

        public void Update(Guide entity)
        {
            _guideDal.Update(entity);
        }
    }

}