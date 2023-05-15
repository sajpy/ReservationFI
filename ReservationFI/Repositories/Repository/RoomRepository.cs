using ReservationFI.Models;

namespace ReservationFI.Repositories.Repository
{
    public class RoomRepository : IRepository.IRoomRepository
    {
        private readonly ReservationDbContext _reservationDbContext;

        public RoomRepository(ReservationDbContext reservationDbContext)
        {
            _reservationDbContext = reservationDbContext;
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _reservationDbContext.Rooms.ToList();
        }

        public int GetIdByRoomName(string roomName)
        {
            return _reservationDbContext.Rooms.First(x => x.RoomName == roomName).Id;
        }
    }
}
