using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationFI.Models;

namespace ReservationFI.Repositories.IRepository
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> GetAll();
        //Reservation? Get(int id);
        void Add(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(Reservation reservation);
        List<string> GetFreeTimes(string date, string roomName);
        List<Reservation>  GetAllReservationsForUser(User user);
        List<Reservation> GetAllReservationsWithRooms();

    }
}
