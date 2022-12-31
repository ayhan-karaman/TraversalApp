using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract.Repository;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IReservationDal:IGenericRepository<Reservation>
    {
        List<Reservation> GetAllReservationsByWaitApproval(int userId);
        List<Reservation> GetAllReservationsByOld(int userId);
        List<Reservation> GetAllReservationsByCurrent(int userId);
    }
}