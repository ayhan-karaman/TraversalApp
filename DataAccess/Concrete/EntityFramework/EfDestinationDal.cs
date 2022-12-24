using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDestinationDal : GenericRepositoryBase<Destination, Context>, IDestinationDal
    {
        public List<Destination> GetAllDestinationIncludesDal()
        {
            using (Context context = new Context())
            {
                var result = context.Destinations.Include(x => x.DestinationImages).Include(x => x.OtherDetails);
                return result.ToList();
            }
        }

        public Destination GetDestinationIncludesDal(Expression<Func<Destination, bool>> filter)
        {
            using (Context context = new Context())
            {
                var result = context.Destinations.Include(x => x.DestinationImages).Include(x => x.OtherDetails).Where(filter);
                return result.SingleOrDefault();
            }
        }
    }
}