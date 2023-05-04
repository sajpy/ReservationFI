using ReservationFI.IRepository;
using ReservationFI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReservationFI.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ReservationDbContext _reservationDbContext;
        private readonly RoomRepository _roomRepository;
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

        public void Update(Reservation reservation)
        {
            throw new NotImplementedException();
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


    }
}
