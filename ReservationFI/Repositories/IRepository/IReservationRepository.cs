using ReservationFI.Models;

namespace ReservationFI.Repositories.IRepository
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> GetAll();
        void Add(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(Reservation reservation);
        List<string> GetFreeTimes(string date, string roomName);
        List<Reservation> GetAllReservations();
        List<Reservation> GetAllReservationsForUser(User user);
        List<Reservation> GetAllReservationsWithRooms();

    }
}
