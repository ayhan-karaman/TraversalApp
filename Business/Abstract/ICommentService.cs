using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        List<Comment> GetAllByDestinationID(int destinationId);
    }
}