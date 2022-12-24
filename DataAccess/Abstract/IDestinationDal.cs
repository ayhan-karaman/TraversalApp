using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccess.Abstract.Repository;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IDestinationDal:IGenericRepository<Destination>
    {
        List<Destination> GetAllDestinationIncludesDal();
        Destination GetDestinationIncludesDal(Expression<Func<Destination, bool>> filter);
    }
}