using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract.Repository;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IFeatureDal:IGenericRepository<Feature>
    {
        
    }
}