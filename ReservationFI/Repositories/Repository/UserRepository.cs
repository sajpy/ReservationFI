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

        public void Delete(User user)
        {
            _reservationDbContext.Users.Remove(user);
            _reservationDbContext.SaveChanges();
        }

        public User? Get(int id)
        {
            return _reservationDbContext.Users.SingleOrDefault(x => x.Id == id);
        }

        public User? GetByUsername(string username)
        {
            return _reservationDbContext.Users.SingleOrDefault(x => x.UserName == username);
        }

        public int GetId(User user)
        {
            return _reservationDbContext.Users.First(x => x.UserName == user.UserName).Id;
        }

        public User? GetByFirstAndLastName(string firstName, string lastName)
        {
            return _reservationDbContext.Users.SingleOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }

        public IEnumerable<User> GetAll()
        {
            return _reservationDbContext.Users.ToList();
        }
        public void Update(User user)
        {
            _reservationDbContext.Users.Update(user);
            _reservationDbContext.SaveChanges();
        }

        public User? Login(string username, string password)
        {
            _currentUser = _reservationDbContext.Users.SingleOrDefault(x => x.UserName == username && x.UserPassword == password);
            return _currentUser;
        }

        public User GetCurrentUser()
        {
            return _currentUser;
        }
    }
}
