using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationFI.IRepository
{
    internal interface IUserRepository
    {
        void Add(User user);
        void Delete(User user);
        User? Get(int id);
        User? GetByUsername(string username);
        User? GetByFirstAndLastName(string firstName, string lastName);
        IEnumerable<User> GetAll();
        void Update(User user);
        User? Login(string username, string password);

    }
}
