using ReservationFI.Models;

namespace ReservationFI.Repositories.IRepository
{
    /// <summary>
    /// Interface for the ReservationRepository, which is used to access the database.
    /// </summary>
    public interface IReservationRepository
    {
        void Add(Reservation reservation);
        void Delete(Reservation reservation);
        List<string> GetFreeTimes(string date, string roomName);
        List<Reservation> GetAllReservations();
        List<Reservation> GetAllReservationsForUser(User user);
    }
}
