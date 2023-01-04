using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfReservationDal : GenericRepositoryBase<Reservation, Context>, IReservationDal
    {
        public List<Reservation> GetAllReservationsByCurrent(int userId)
        {
            using (var context = new Context())
            {
                var result = context.Reservations
                .Include(x => x.Destination)
                .ThenInclude(x => x.DestinationImages)
                .Where(x => x.AppUserId == userId && x.Status == "Onaylandı");
                return result.ToList();
            }
        }

        public List<Reservation> GetAllReservationsByOld(int userId)
        {
            using (var context = new Context())
            {
                var result = context.Reservations
                .Include(x => x.Destination)
                .ThenInclude(x => x.DestinationImages)
                .Where(x => x.AppUserId == userId && (x.Status == "Tamamlandı" || x.Status == "Acente İptali" || x.Status == "Müşteri İptali"));
                return result.ToList();
            }
        }

        public List<Reservation> GetAllReservationsByWaitApproval(int userId)
        {
            using (var context = new Context())
            {
                var result = context.Reservations
                .Include(x => x.Destination)
                .ThenInclude(x => x.DestinationImages)
                .Where(x => x.AppUserId == userId && x.Status == "Onay Bekliyor");
                return result.ToList();
            }
        }
    }
}