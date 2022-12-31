using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Add(Reservation entity)
        {
            _reservationDal.Insert(entity);
        }

        public void Delete(Reservation entity)
        {
            _reservationDal.Insert(entity);
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public List<Reservation> GetAllReservationByUserIdAndStatusCurrent(int userId)
        {
            return _reservationDal.GetAllReservationsByCurrent(userId);
        }

        public List<Reservation> GetAllReservationByUserIdAndStatusOld(int userId)
        {
            return _reservationDal.GetAllReservationsByOld(userId);
        }

        public List<Reservation> GetAllReservationByUserIdAndStatusWaitApproval(int userId)
        {
            return _reservationDal.GetAllReservationsByWaitApproval(userId);
        }

        public Reservation GetById(int id)
        {
            return _reservationDal.Get(x => x.ID == id);
        }

        public void Update(Reservation entity)
        {
            _reservationDal.Update(entity);
        }
    }
}