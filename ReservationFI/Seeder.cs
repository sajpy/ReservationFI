using ReservationFI.Models;

namespace ReservationFI
{
    public class Seeder
    {
        private readonly ReservationDbContext _dbContext;

        public Seeder(ReservationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Method for seeding the database with some data.
        /// </summary>
        public void SeedData()
        {
            bool roomsExist = _dbContext.Rooms.Any();

            if (!roomsExist)
            {
                // ignore the capacity, meant for future upgrades
                var room1 = new Room { RoomName = "A102", RoomCapacity = 10 };
                var room2 = new Room { RoomName = "A105", RoomCapacity = 10 };
                var room3 = new Room { RoomName = "A106", RoomCapacity = 10 };
                var room4 = new Room { RoomName = "A202", RoomCapacity = 10 };
                var room5 = new Room { RoomName = "A203", RoomCapacity = 10 };
                var room6 = new Room { RoomName = "A204", RoomCapacity = 10 };
                var room7 = new Room { RoomName = "A205", RoomCapacity = 10 };
                var room8 = new Room { RoomName = "A206", RoomCapacity = 10 };
                var room9 = new Room { RoomName = "A207", RoomCapacity = 10 };
                var room10 = new Room { RoomName = "A208", RoomCapacity = 10 };

                _dbContext.Rooms.AddRange(room1, room2, room3, room4, room5, room6, room7, room8, room9, room10);
                _dbContext.SaveChanges();
            }

            bool usersExist = _dbContext.Users.Any();

            if (!usersExist)
            {
                var user1 = new User { FirstName = "Steven", LastName = "Anderson", UserName = "admin", UserPassword = "admin", IsAdmin = true };
                var user2 = new User { FirstName = "Wayne", LastName = "Craig", UserName = "user", UserPassword = "user", IsAdmin = false };

                if (!_dbContext.Users.Contains(user1) && !_dbContext.Users.Contains(user2))
                {
                    _dbContext.Users.AddRange(user1, user2);
                }

                _dbContext.SaveChanges();
            }
        }
    }
}
