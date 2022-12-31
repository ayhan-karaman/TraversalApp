using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
        List<Reservation> GetAllReservationByUserIdAndStatusWaitApproval(int userId);
        List<Reservation> GetAllReservationByUserIdAndStatusOld(int userId);
        List<Reservation> GetAllReservationByUserIdAndStatusCurrent(int userId);
    }
}