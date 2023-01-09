using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IDestinationImageService:IGenericService<DestinationImage>
    {
        IResult AddImage(ICollection<IFormFile> files, int id);
        IDataResult<List<DestinationImage>> GetByDestinationId(int destinationId);
    }
}