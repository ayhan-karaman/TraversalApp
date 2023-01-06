using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Dtos;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IDestinationService:IGenericService<Destination>
    {
        IDataResult<List<Destination>> GetAllDestinationIncludes();
        Destination GetByIdDestinationIncludes(int id);
    }
}