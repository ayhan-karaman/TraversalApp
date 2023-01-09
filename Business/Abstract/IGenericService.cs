using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IGenericService<T>
    {
        IResult Add(T entity);
        IResult Delete(T entity);
        IResult Update(T entity);
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);
    }
}