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

        public IResult Add(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
            return new SuccessResult("");
        }

        public IResult Delete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
             return new SuccessResult();
        }

        public IDataResult<List<Testimonial>> GetAll()
        {
            return new SuccessDataResult<List<Testimonial>>(_testimonialDal.GetAll());
        }

        public IDataResult<Testimonial> GetById(int id)
        {
            return new SuccessDataResult<Testimonial>(_testimonialDal.Get(x => x.ID == id));
        }

        public IResult Update(Testimonial entity)
        {
           _testimonialDal.Update(entity);
            return new SuccessResult();
        }
    }

}