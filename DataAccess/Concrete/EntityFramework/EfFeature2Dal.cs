using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFeature2Dal:GenericRepositoryBase<Feature2, Context>,  IFeature2Dal
    {
        
    }
}