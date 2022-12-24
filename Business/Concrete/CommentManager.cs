using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
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

        public void Add(Comment entity)
        {
            entity.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            entity.State = true;
            _commentDal.Insert(entity);
        }

        public void Delete(Comment entity)
        {
           _commentDal.Delete(entity);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public List<Comment> GetAllByDestinationID(int destinationId)
        {
            return _commentDal.GetAll(x => x.DestinationID == destinationId);
        }

        public Comment GetById(int id)
        {
            return _commentDal.Get(x => x.ID == id);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}