using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationFI.Models;

namespace ReservationFI.IRepository
{
    internal interface IReservationRepository
    {
        IEnumerable<Reservation> GetAll();
        //Reservation? Get(int id);
        void Add(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(Reservation reservation);
        List<string> GetFreeTimes(string date, string roomName);

    }
}
