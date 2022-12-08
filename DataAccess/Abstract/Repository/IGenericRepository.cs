using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Repository
{
    public interface IGenericRepository<T>
     where T:class, new()
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T  entity);
        List<T> GetAll(Expression<Func<T,  bool>> filter = null);
        T Get(Expression<Func<T,  bool>> filter);
    }
}