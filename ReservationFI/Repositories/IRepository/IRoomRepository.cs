using ReservationFI.Models;

namespace ReservationFI.Repositories.IRepository
{
    /// <summary>
    /// Interface for the RoomRepository, which is used to access the database.
    /// </summary>
    public interface IRoomRepository
    {
        int GetIdByRoomName(string roomName);
        IEnumerable<Room> GetAllRooms();
    }
}
