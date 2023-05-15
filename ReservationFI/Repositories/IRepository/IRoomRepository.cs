using ReservationFI.Models;

namespace ReservationFI.Repositories.IRepository
{
    public interface IRoomRepository
    {
        int GetIdByRoomName(string roomName);
        IEnumerable<Room> GetAllRooms();
    }
}
