using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationFI.Models;

namespace ReservationFI.IRepository
{
    internal interface IRoomRepository
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
