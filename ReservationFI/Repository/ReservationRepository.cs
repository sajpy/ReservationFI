using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationFI.Repository
{
    public class ReservationRepository : IRepository.IReservationRepository
    {
        private readonly ReservationDbContext _reservationDbContext;
        public ReservationRepository(ReservationDbContext reservationDbContext)
        {
            _reservationDbContext = reservationDbContext;
        }

        public void Add(Reservation reservation)
        {
            _reservationDbContext.Reservations.Add(reservation);
            _reservationDbContext.SaveChanges();
        }
        public void Delete(Reservation reservation)
        {
            _reservationDbContext.Reservations.Remove(reservation);
            _reservationDbContext.SaveChanges();
        }
        public IEnumerable<Reservation> GetAll()
        {
            return _reservationDbContext.Reservations.ToList();
        }



    }
}
