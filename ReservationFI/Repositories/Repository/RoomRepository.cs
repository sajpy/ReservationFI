using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void Add(Room room)
        {
            _reservationDbContext.Rooms.Add(room);
            _reservationDbContext.SaveChanges();
        }
        public void Delete(Room room)
        {
            _reservationDbContext.Rooms.Remove(room);
            _reservationDbContext.SaveChanges();
        }
        public Room? Get(int id)
        {
            return _reservationDbContext.Rooms.SingleOrDefault(x => x.Id == id);
        }
        public IEnumerable<string> GetAll()
        {
            return _reservationDbContext.Rooms.Select(x => x.RoomName).ToList();
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _reservationDbContext.Rooms.ToList();
        }

        public int GetIdByRoomName(string roomName)
        {
            return _reservationDbContext.Rooms.First(x => x.RoomName == roomName).Id;
        }

        public void Update(Room room)
        {
            _reservationDbContext.Rooms.Update(room);
            _reservationDbContext.SaveChanges();
        }



    }
}
