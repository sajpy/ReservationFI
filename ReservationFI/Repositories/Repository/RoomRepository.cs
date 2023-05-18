using ReservationFI.Models;

namespace ReservationFI.Repositories.Repository
{
    /// <summary>
    /// Repository for the Room model, which is used to access the database.
    /// </summary>
    public class RoomRepository : IRepository.IRoomRepository
    {
        private readonly ReservationDbContext _reservationDbContext;

        public RoomRepository(ReservationDbContext reservationDbContext)
        {
            _reservationDbContext = reservationDbContext;
        }

        /// <summary>
        /// Method for getting all rooms from the database.
        /// </summary>
        public IEnumerable<Room> GetAllRooms()
        {
            return _reservationDbContext.Rooms.ToList();
        }

        /// <summary>
        /// Method for getting the id of a room by its name.
        /// </summary>
        public int GetIdByRoomName(string roomName)
        {
            return _reservationDbContext.Rooms.First(x => x.RoomName == roomName).Id;
        }
    }
}
