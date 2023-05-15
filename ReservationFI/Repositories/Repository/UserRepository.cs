using ReservationFI.Models;
using ReservationFI.Repositories.IRepository;

namespace ReservationFI.Repositories.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ReservationDbContext _reservationDbContext;
        private User? _currentUser;

        public UserRepository(ReservationDbContext reservationDbContext)
        {
            _reservationDbContext = reservationDbContext;
        }
        public void Add(User user)
        {
            _reservationDbContext.Users.Add(user);
            _reservationDbContext.SaveChanges();
        }

        public User? GetByFirstAndLastName(string firstName, string lastName)
        {
            return _reservationDbContext.Users.SingleOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }

        public User? Login(string username, string password)
        {
            _currentUser = _reservationDbContext.Users.SingleOrDefault(x => x.UserName == username && x.UserPassword == password);
            return _currentUser;
        }

        public User? GetCurrentUser()
        {
            return _currentUser;
        }
    }
}
