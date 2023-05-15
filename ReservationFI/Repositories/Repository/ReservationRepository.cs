using Microsoft.EntityFrameworkCore;
using ReservationFI.Models;
using ReservationFI.Repositories.IRepository;
using System.Collections;

namespace ReservationFI.Repositories.Repository
{
    public class ReservationRepository : IReservationRepository
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
            var existingReservation = _reservationDbContext.Reservations.Find(reservation.Id);
            if (existingReservation != null)
            {
                _reservationDbContext.Entry(existingReservation).State = EntityState.Detached;
            }

            _reservationDbContext.Reservations.Remove(reservation);
            _reservationDbContext.SaveChanges();
        }

        public List<string> GetFreeTimes(string date, string roomName)
        {
            int roomId = _reservationDbContext.Rooms.Where(x => x.RoomName == roomName).First().Id;
            List<string> notFreeTimes = _reservationDbContext.Reservations.Where(x => x.StartDate == date && x.RoomId == roomId).Select(x => x.StartTime).ToList();

            IEnumerable values = Enum.GetValues(typeof(Times.TimesEnum));

            List<string> freeTimes = new();

            foreach (Times.TimesEnum item in values)
            {
                if (!notFreeTimes.Contains(item.GetDescription()))
                {
                    freeTimes.Add(item.GetDescription());
                }
            }
            return freeTimes;
        }

        public List<Reservation> GetAllReservations()
        {
            var reservationsWithRooms = _reservationDbContext.Reservations
                .Join(_reservationDbContext.Rooms, res => res.RoomId, room => room.Id, (res, room) => new
                {
                    Res = res,
                    Room = room
                })
                .Join(_reservationDbContext.Users, user => user.Res.UserId, user2 => user2.Id, (user, user2) => new Reservation
                {
                    Id = user.Res.Id,
                    RoomId = user.Res.RoomId,
                    RoomName = user.Room.RoomName,
                    StartDate = user.Res.StartDate,
                    StartTime = user.Res.StartTime,
                    EndTime = user.Res.EndTime,
                    UserId = user.Res.UserId,
                    UserFirstName = user2.FirstName,
                    UserLastName = user2.LastName,
                })
                .OrderBy(x => x.StartDate)
                .ThenBy(x => x.StartTime)
                .ToList();

            return reservationsWithRooms;

        }

        public List<Reservation> GetAllReservationsForUser(User user)
        {
            return GetAllReservations().Where(x => x.UserId == user.Id).ToList();
        }

    }
}
