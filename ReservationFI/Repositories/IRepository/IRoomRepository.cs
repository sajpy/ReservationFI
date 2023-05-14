using ReservationFI.Models;

namespace ReservationFI.Repositories.IRepository
{
    public interface IRoomRepository
    {
        IEnumerable<string> GetAll();
        Room? Get(int id);
        int GetIdByRoomName(string roomName);
        void Add(Room room);
        void Update(Room room);
        void Delete(Room room);

        IEnumerable<Room> GetAllRooms();
    }
}
