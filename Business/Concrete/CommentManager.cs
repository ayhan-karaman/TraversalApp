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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment entity)
        {
            entity.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            entity.State = true;
            _commentDal.Insert(entity);
            return new SuccessResult("");
        }

        public IResult Delete(Comment entity)
        {
           _commentDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Comment>> GetAll()
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll());
        }

        public List<Comment> GetAllByDestinationID(int destinationId)
        {
            return _commentDal.GetAll(x => x.DestinationID == destinationId);
        }

        public IDataResult<Comment> GetById(int id)
        {
            return new SuccessDataResult<Comment> (_commentDal.Get(x => x.ID == id));
        }

        public IResult Update(Comment entity)
        {
            _commentDal.Update(entity);
             return new SuccessResult();
        }
    }
}