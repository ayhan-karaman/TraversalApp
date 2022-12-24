using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDestinationImageDal:GenericRepositoryBase<DestinationImage, Context>,  IDestinationImageDal
    {
        
    }
}