using ReservationFI.Models;


namespace ReservationFI.Repositories.IRepository
{
    public interface IUserRepository
    {
        void Add(User user);
        User? GetByFirstAndLastName(string firstName, string lastName);
        User? Login(string username, string password);
        User? GetCurrentUser();
    }
}
