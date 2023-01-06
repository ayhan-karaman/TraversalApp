using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void Delete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public IDataResult<List<Testimonial>> GetAll()
        {
            return new SuccessDataResult<List<Testimonial>>(_testimonialDal.GetAll());
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.Get(x => x.ID == id);
        }

        public void Update(Testimonial entity)
        {
           _testimonialDal.Update(entity);
        }
    }

}