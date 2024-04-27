using AutoMapper;
using CodeDrivers.Models.Car;
using CodeDriversMVC.DataAccess;
using CodeDriversMVC.Models;

namespace CodeDriversMVC.Services
{
    public class UserReservationService
    {
        private readonly CodeDriversContext _context;

        public UserReservationService(CodeDriversContext context, IMapper mapper)
        {
            _context = context; 
        }

        public List<UserReservationModel> GetUserReservations(string email)
        {
            var reservations = _context.Reservations.Where(r => r.Owner.Email == email);
            var reservationResult = reservations.Select(reservation => new UserReservationModel
            {
                ReservationId = reservation.ReservationId,
                Brand = reservation.Car.Brand,
                Model = reservation.Car.Model,
                ReservationFrom = reservation.ReservationFrom,
                ReservationTo = reservation.ReservationTo,
                TotalReservationPrice = reservation.TotalReservationPrice,
                ReservationDuration = reservation.Duration
            }).ToList();

            return reservationResult;
        }

        public void CancelReservation(int reservationId)
        {
            var reservationToBeRemoved = _context.Reservations.FirstOrDefault(r => r.ReservationId == reservationId);
            _context.Reservations.Remove(reservationToBeRemoved);
            _context.SaveChanges();
        }

    }
}
