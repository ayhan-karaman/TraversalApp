using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        string Message { get; set; }
        bool Success { get; set; }
    }
}