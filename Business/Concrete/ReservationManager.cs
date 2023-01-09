using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Reservation entity)
        {
            _reservationDal.Insert(entity);
            return new SuccessResult("");
        }

        public IResult Delete(Reservation entity)
        {
            _reservationDal.Insert(entity);
             return new SuccessResult();
        }

        public IDataResult<List<Reservation>> GetAll()
        {
            return new SuccessDataResult<List<Reservation>>(_reservationDal.GetAll());
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

        public IDataResult<Reservation> GetById(int id)
        {
            return new SuccessDataResult<Reservation>(_reservationDal.Get(x => x.ID == id));
        }

        public IResult Update(Reservation entity)
        {
            _reservationDal.Update(entity);
             return new SuccessResult();
        }
    }
}