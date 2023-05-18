using ReservationFI.Models;
using ReservationFI.Repositories.IRepository;

namespace ReservationFI.Repositories.Repository
{
    /// <summary>
    /// Repository for the User model, which is used to access the database.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly ReservationDbContext _reservationDbContext;
        private User? _currentUser;

        public UserRepository(ReservationDbContext reservationDbContext)
        {
            _reservationDbContext = reservationDbContext;
        }

        /// <summary>
        /// Method for adding a user to the database.
        /// </summary>
        public void Add(User user)
        {
            _reservationDbContext.Users.Add(user);
            _reservationDbContext.SaveChanges();
        }

        /// <summary>
        /// Method for getting a user by first and last name.
        /// </summary>
        /// <param name="firstName">users's first name</param>
        /// <param name="lastName">user's last name</param>
        public User? GetByFirstAndLastName(string firstName, string lastName)
        {
            return _reservationDbContext.Users.SingleOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }

        /// <summary>
        /// Method for logging in a user.
        /// </summary>
        /// <param name="username">user's username</param>
        /// <param name="password">user's password</param>
        public User? Login(string username, string password)
        {
            _currentUser = _reservationDbContext.Users.SingleOrDefault(x => x.UserName == username && x.UserPassword == password);
            return _currentUser;
        }

        /// <summary>
        /// Method for getting the current user.
        /// </summary>
        public User? GetCurrentUser()
        {
            return _currentUser;
        }
    }
}
