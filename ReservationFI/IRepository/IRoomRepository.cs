using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationFI.IRepository
{
    internal interface IRoomRepository
    {
        IEnumerable<string> GetAll();
        Room? Get(int id);
        void Add(Room room);
        void Update(Room room);
        void Delete(Room room);

        IEnumerable<Room> GetAllRooms();
    }
}
