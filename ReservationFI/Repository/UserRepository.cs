using Microsoft.VisualBasic.ApplicationServices;
using ReservationFI.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationFI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ReservationDbContext _reservationDbContext;
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
            return _reservationDbContext.Users.SingleOrDefault(x => x.Username == username);
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
            return _reservationDbContext.Users.SingleOrDefault(x => x.Username == username && x.UserPassword == password);
        }
    }
}
